using Abp.Application.Services.Dto;
using System;

namespace VCM.MIT.Data.Entities.Trans
{
    public class TransHeaderDto : FullAuditedEntityDto<Guid>
    {
        public new Guid? Id { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public int DeliveringMethod { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string DeliveryToHub { get; set; }
        public string DeliveryToProvince { get; set; }
        public string DeliveryToDistrict { get; set; }
        public string DeliveryToWard { get; set; }
        public string DeliveryToAddress { get; set; }
        public string DeliveryToName { get; set; }
        public string DeliveryToPhone { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal AmountInclVAT { get; set; }
        public int Status { get; set; }
        public string AppCode { get; set; }
        public string CompanyCode { get; set; }
        public string StoreNo { get; set; }
        public string PosNo { get; set; }
        public string ShiftCode { get; set; }
        public string CashierID { get; set; }
        public int PrintedNumber { get; set; }
        public DateTime OrderTime { get; set; }
        public string MemberCardNo { get; set; }
        public int Returned { get; set; }
        public string ReturnedReceiptNo { get; set; }
        public bool IssuedVATInvoice { get; set; }
        public bool SendingStatus { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public string BillNumber { get; set; }
        public string RefKey1 { get; set; }
        public string RefKey2 { get; set; }
        public string IPAddress { get; set; }
    }
    public class TransHeaderViewDto
    {
        public TransHeaderDto TransHeaderDto { get; set; }
    }
    public class CreateTransHeaderDto : TransHeaderDto
    {

    }
    public class TransHeaderFilterDto: TransHeaderDto
    {
        
    }
}
