using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Trans;

namespace VCM.MIT.Entities
{
    [AutoMap(typeof(TransHeaderViewDto))]
    [NotMapped]
    public class TransHeaderView
    {
        public TransHeader TransHeader { get; set; }
    }

    [AutoMap(typeof(TransHeaderDto))]
    [Table("M_TransHeader")]
    public class TransHeader : FullAuditedEntity<Guid>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }

        [StringLength(MITConsts.OrderNoStringLength)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        [StringLength(10)]
        public string AppCode { get; set; }
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [StringLength(6)]
        public string StoreNo { get; set; }
        [StringLength(3)]
        public string PosNo { get; set; }
        public int ShiftCode { get; set; }
        [StringLength(10)]
        public string CashierID { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal AmountInclVAT { get; set; }
        [StringLength(10)]
        public string OrderType { get; set; }
        public int Status { get; set; }
        [StringLength(30)]
        public string CustNo { get; set; }
        [StringLength(150)]
        public string CustName { get; set; }
        [StringLength(50)]
        public string CustPhone { get; set; }
        [StringLength(50)]
        public string MemberCardNo { get; set; }
        public decimal MemberPointsEarn { get; set; }
        public decimal MemberPointsRedeem { get; set; }
        public int DeliveringMethod { get; set; }
        [StringLength(150)]
        public string DeliveryToName { get; set; }
        [StringLength(50)]
        public string DeliveryToPhone { get; set; }
        [StringLength(100)]
        public string DeliveryToProvince { get; set; }
        [StringLength(100)]
        public string DeliveryToDistrict { get; set; }
        [StringLength(100)]
        public string DeliveryToWard { get; set; }
        [StringLength(MITConsts.MaxTitleLength)]
        public string DeliveryToAddress { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime DeliveryTime { get; set; }
        [StringLength(10)]
        public int PrintedNumber { get; set; }
        public DateTime PrintedDate { get; set; }
        public DateTime OrderTime { get; set; }
        public int Returned { get; set; }
        [StringLength(30)]
        public string ReferenceNo { get; set; }
        public bool IsInvoice { get; set; }
        [StringLength(1500)]
        public string InvoiceInfo { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        [StringLength(50)]
        public string BillNumber { get; set; }
        [StringLength(50)]
        public string RefKey1 { get; set; }
        [StringLength(50)]
        public string RefKey2 { get; set; }
        [StringLength(50)]
        public string IPAddress { get; set; }
    }
}
