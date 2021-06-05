using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Trans;

namespace VCM.MIT.Entities
{
    [AutoMap(typeof(TransPaymentEntryViewDto))]
    [NotMapped]
    public class TransPaymentEntryView
    {
        public TransPaymentEntry TransPaymentEntry { get; set; }
    }

    [AutoMap(typeof(TransPaymentEntryDto))]
    [Table("M_TransPaymentEntry")]
    public class TransPaymentEntry : FullAuditedEntity<Guid>
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
        [StringLength(6)]
        public string StoreNo { get; set; }
        [StringLength(3)]
        public string PosNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ShiftCode { get; set; }
        [StringLength(10)]
        public string CashierID { get; set; }
        [StringLength(10)]
        public string TenderType { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal AmountTendered { get; set; }
        [StringLength(3)]
        public string CurrencyCode { get; set; }
        public decimal AmountInCurrency { get; set; }
        public int CardPaymentType { get; set; }
        public decimal CardValue { get; set; }
        [StringLength(50)]
        public string ReferenceNo { get; set; }
        [StringLength(50)]
        public string PayForOrderNo { get; set; }
        [StringLength(500)]
        public string TransactionNo { get; set; }
    }
}
