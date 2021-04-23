using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCM.MIT.Data.Entities.Trans
{
    public class TransLineDto : FullAuditedEntityDto<Guid>
    {
        public new Guid? Id { get; set; }
        public string OrderNo { get; set; }
        public int LineNo_ { get; set; }
        public int LineType { get; set; }
        public string ItemNo { get; set; }
        public string ItemName { get; set; }
        public string UOM { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal LineAmountExcVat { get; set; }
        public string VatGroup { get; set; }
        public decimal VatPercent { get; set; }
        public decimal VatAmount { get; set; }
        public decimal LineAmount { get; set; }
        public bool BlockedMember { get; set; }
        public int MemberPointsEarn { get; set; }
        public int MemberPointsRedeem { get; set; }
        public int BluePointsRedeem { get; set; }
        public int BluePointsEarn { get; set; }
        public decimal AmountCalPoint { get; set; }
        public DateTime ScanTime { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Barcode { get; set; }
        public string LotNo { get; set; }
        public string SerialNo { get; set; }
        public string ItemType { get; set; }
        public int DeliveringMethod { get; set; }
        public decimal ReturnedQuantity { get; set; }
        public decimal DeliveryQuantity { get; set; }
        public string StoreNo { get; set; }

    }
    public class TransLineViewDto
    {
        public TransLineDto TransLineDto { get; set; }
    }
    public class CreateTransLineDto : TransLineDto
    {

    }
    public class TransLineFilterDto : TransLineDto
    {
    }

}
