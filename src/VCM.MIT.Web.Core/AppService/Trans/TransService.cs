using Abp.BackgroundJobs;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.UI;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VCM.MIT.Authorization.Users;
using VCM.MIT.Data.Entities.Trans;
using VCM.MIT.Models.Trans;
using VCM.MIT.Models.User;
using VCM.MIT.Users;
using VCM.MIT.VCM.Interfaces;

namespace VCM.MIT.AppService.Trans
{
    public class TransService : ITransService
    {
        private readonly ILogger _logger;
        private readonly IRepository<User, long> _repositoryUser;
        private readonly ITransRawAppService _transRawAppService;
        private readonly ITransHeaderAppService _transHeaderAppService;
        private readonly ITransLineAppService _transLineAppService;
        private readonly ITransPaymentEntryAppService _transPaymentEntryAppService;
        private readonly ITransDiscountEntryAppService _transDiscountEntryAppService;


        public TransService(
            IRepository<User, long> repositoryUser,
            ITransRawAppService transRawAppService,
            ITransHeaderAppService transHeaderAppService,
            ITransLineAppService transLineAppService,
            ITransPaymentEntryAppService transPaymentEntryAppService,
            ITransDiscountEntryAppService transDiscountEntryAppService,
            ILogger logger
            )
        {
            _repositoryUser = repositoryUser;
            _transRawAppService = transRawAppService;
            _transHeaderAppService = transHeaderAppService;
            _transLineAppService = transLineAppService;
            _transPaymentEntryAppService = transPaymentEntryAppService;
            _transDiscountEntryAppService = transDiscountEntryAppService;
            _logger = logger;
        }
        
        public async Task<string> CreateTransHeader(TransHeaderModel input)
        {
            try
            {
                var transHeader = new TransHeaderDto()
                {
                    Id = Guid.NewGuid(),
                    OrderNo = input.OrderNo,
                    OrderDate = input.OrderDate,
                    CustNo = "",
                    CustName = input.CustName,
                    DeliveringMethod = 0,
                    DeliveryDate = DateTime.Now,
                    DeliveryTime = DateTime.Now,
                    DeliveryToProvince = "",
                    DeliveryToDistrict = "",
                    DeliveryToWard = "",
                    DeliveryToAddress = "",
                    DeliveryToName = "",
                    DeliveryToPhone = "",
                    DiscountAmount = input.DiscountAmount,
                    AmountInclVAT = input.TotalAmountInclVAT,
                    Status = 0,
                    AppCode = "VCM",
                    CompanyCode = "",
                    StoreNo = input.StoreNo,
                    PosNo = input.PosNo ?? "999",
                    ShiftCode = int.Parse(input.ShiftCode??"0"),
                    CashierID = input.CashierID,
                    PrintedNumber = 0,
                    PrintedDate = DateTime.Now,
                    OrderTime = DateTime.Now,
                    MemberCardNo = input.MemberCardNo,
                    Returned = input.Returned,
                    ReferenceNo = input.RefOrder.ToString(),
                    IsInvoice = input.IssuedVATInvoice,
                    InvoiceInfo = "",
                    StartingTime = DateTime.Now,
                    EndingTime = DateTime.Now,
                    BillNumber = "",
                    RefKey1 = "",
                    RefKey2 = "",
                    IPAddress = ""
                };

                var transResult =  await _transHeaderAppService.CreateAsync(transHeader);
                await CreateTransLine(input.StoreNo, input.PosNo ?? "999", input.OrderNo, input.Items);
                await CreateTransPaymentEntry(input.StoreNo, input.PosNo ?? "999", input.OrderNo, input.Payments);

                return transResult.Id.ToString();
            }
            catch (UserFriendlyException)
            {
                throw;
            }
            catch (Exception e)
            {
                _logger.Warn("CreateTransHeader Exception: " + e.Message.ToString());
                throw new ValidationException("Exception ", e);
            }
        }
        public async Task<bool> CreateTransLine(string storeNo, string posNo, string orderNo, List<TransLineModel> input)
        {
            try
            {
                if (input.Count > 0)
                {
                    var lineNo_ = 1000;
                    foreach (var line in input)
                    {
                        var item = new TransLineDto()
                        {
                            Id = Guid.NewGuid(),
                            OrderNo = orderNo,
                            LineNo_ = line.LineNo,
                            LineType = 0,
                            ItemNo=line.ItemNo,
                            ItemName = line.ItemName,
                            UOM = line.UOM,
                            Qty = line.Qty,
                            UnitPrice = line.UnitPrice,
                            DiscountPercent = 0,
                            DiscountAmount = line.DiscountAmount,
                            TotalAmount = line.UnitPrice * line.Qty,
                            LineAmountExcVat = line.LineAmount,
                            VatGroup = "",
                            VatPercent = line.VatPercent,
                            VatAmount = line.VatAmount,
                            LineAmount = line.LineAmount,
                            BlockedMember = false,
                            MemberPointsEarn = 0,
                            MemberPointsRedeem = 0,
                            BluePointsRedeem = 0,
                            BluePointsEarn = 0,
                            AmountCalPoint = line.UnitPrice * line.Qty,
                            ScanTime = DateTime.Now,
                            Barcode = line.Barcode,
                            LotNo = "",
                            ExpireDate = DateTime.Now,
                            SerialNo = line.SerialNo,
                            ItemType = "",
                            DeliveringMethod = 0,
                            ReturnedQuantity = 0,
                            DeliveryQuantity = 0,
                            StoreNo = storeNo
                        };

                        await _transLineAppService.CreateAsync(item);
                        lineNo_++;
                    }
                }
                return true;
            }
            catch (UserFriendlyException)
            {
                throw;
            }
            catch (Exception e)
            {
                _logger.Warn("CreateTransPaymentEntry Exception: " + e.Message.ToString());
                throw new ValidationException("Exception ", e);
            }
        }
        public async Task<bool> CreateTransPaymentEntry(string storeNo, string posNo, string orderNo, List<TransPaymentEntryModel> input)
        {
            try
            {
                if (input.Count > 0)
                {
                    var lineNo_ = 1000;
                    foreach (var line in input)
                    {
                        var item = new TransPaymentEntryDto()
                        {
                            Id = Guid.NewGuid(),
                            OrderNo = orderNo,
                            LineNo_ = lineNo_,
                            PaymentDate = line.PaymentDate,
                            StoreNo = storeNo,
                            PosNo = posNo,
                            ShiftCode = "0",
                            CashierID = line.CashierID,
                            TenderType = line.TenderType,
                            ExchangeRate = line.ExchangeRate,
                            AmountTendered = line.PaymentAmount,
                            CurrencyCode = "VND",
                            AmountInCurrency = line.PaymentAmount*line.ExchangeRate,
                            CardPaymentType = 0,
                            CardValue = 0,
                            ReferenceNo = line.VoucherNo,
                            PayForOrderNo = "",
                            TransactionNo=""
                        };
                        await _transPaymentEntryAppService.CreateAsync(item);
                        lineNo_++;
                    }
                }
                return true;
            }
            catch (UserFriendlyException)
            {
                throw;
            }
            catch (Exception e)
            {
                _logger.Warn("CreateTransPaymentEntry Exception: " + e.Message.ToString());
                throw new ValidationException("Exception ", e);
            }
        }
        public async Task<bool> CreateTransDiscountEntry(string orderNo, string itemNo, int lineNo, List<TransDiscountEntryModel> input)
        {
            try
            {
                if(input.Count > 0)
                {
                    var lineNo_ = 1000;
                    foreach(var line in input)
                    {
                        var item = new TransDiscountEntryDto()
                        {
                            Id = new Guid(),
                            OrderNo = orderNo,
                            LineNo_ = lineNo_,
                            OrderLineNo = lineNo,
                            OfferNo = line.OfferNo,
                            OfferType = line.OfferType,
                            Qty = line.Qty,
                            DiscountType = line.DiscountType,
                            DiscountAmount = line.DiscountAmount,
                            ParentLineNo = lineNo,
                            ItemNo = itemNo,
                            LineGroup = ""
                        };
                        await _transDiscountEntryAppService.CreateAsync(item);
                        lineNo_++;
                    }
                }
                return true;
            }
            catch (UserFriendlyException)
            {
                throw;
            }
            catch (Exception e)
            {
                _logger.Warn("CreateTransDiscountEntry Exception: " + e.Message.ToString());
                throw new ValidationException("Exception ", e);
            }
        }
        public async Task<string> CreateTransRawAsync(UserInToken userInfo,  TransHeaderModel input)
        {
            try
            {
                var user = _repositoryUser.GetAll().Where(x => x.Id == userInfo.UserId).FirstOrDefault();
                TransRawDto transRawDto = new TransRawDto() {
                    Id = Guid.NewGuid(),
                    AppCode = user.AuthenticationSource,
                    CompanyCode = "VCM",
                    StoreNo = input.StoreNo,
                    PosNo = "000",
                    EntryDate = DateTime.Now.ToString("yyyyMMdd"),
                    DateInsert = DateTime.Now,
                    TranNo = input.OrderNo,
                    RawData = System.Text.Json.JsonSerializer.Serialize(input).ToString(),
                    UpdateFlg = "N",
                    IPAddress = "",
                    MACAddress = ""
                };
                var transResult = await _transRawAppService.CreateAsync(transRawDto);
                return transResult.Id.ToString();
            }
            catch (UserFriendlyException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new ValidationException("CreateTransRawAsync Exception ", e);
            }
        }
        public async Task<string> CreateTransRawMasterAsync(UserInToken userInfo, TransRawModel input)
        {
            try
            {
                var user = _repositoryUser.GetAll().Where(x => x.Id == userInfo.UserId).FirstOrDefault();
                TransRawDto transRawDto = new TransRawDto()
                {
                    Id = Guid.NewGuid(),
                    AppCode = user.AuthenticationSource ?? "MIT",
                    CompanyCode = input.CompanyCode ?? "VCM",
                    StoreNo = input.StoreNo ?? "100001",
                    PosNo = input.PosNo ?? "MIT",
                    EntryDate = DateTime.Now.ToString("yyyyMMdd"),
                    DateInsert = DateTime.Now,
                    TranNo = input.TranNo.ToString()??DateTime.Now.ToString("yyMMddHHmmssfff"),
                    RawData = input.RawData.ToString()??"{}",
                    UpdateFlg = "N",
                    IPAddress = input.IpAddress ?? "",
                    MACAddress = input.MacAddress ?? ""
                };
                var transResult = await _transRawAppService.CreateAsync(transRawDto);
                return transResult.Id.ToString();
            }
            catch (UserFriendlyException)
            {
                throw;
            }
            catch (Exception e)
            {
                _logger.Warn("CreateTransRawMasterAsync Exception: " + e.Message.ToString());
                throw new ValidationException("CreateTransRawMasterAsync Exception ", e);
            }
        }
    }
}
