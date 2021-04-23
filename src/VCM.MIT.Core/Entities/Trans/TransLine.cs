using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Trans;

namespace VCM.MIT.Entities
{
    [AutoMap(typeof(TransLineViewDto))]
    [NotMapped]
    public class TransLineView
    {
        public TransLine TransLine { get; set; }
    }

    [AutoMap(typeof(TransLineDto))]
    [Table("M_TransLine")]
    public class TransLine : FullAuditedEntity<Guid>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }

        [StringLength(MITConsts.OrderNoStringLength)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string OrderNo { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int LineNo_ { get; set; }
        public int LineType { get; set; }
        [StringLength(18)]
        public string ItemNo { get; set; }
        public string ItemName { get; set; }
        [StringLength(10)]
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
        [StringLength(30)]
        public string Barcode { get; set; }
        [StringLength(50)]
        public string LotNo { get; set; }
        public DateTime ExpireDate { get; set; }
        [StringLength(50)]
        public string SerialNo { get; set; }
        [StringLength(10)]
        public string ItemType { get; set; }
        public int DeliveringMethod { get; set; }
        public decimal ReturnedQuantity { get; set; }
        public decimal DeliveryQuantity { get; set; }
        [StringLength(6)]
        public string StoreNo { get; set; }
    }
}
