using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VCM.MIT.Data.Entities
{
    [AutoMap(typeof(CashDepositViewDto))]
    [NotMapped]
    public class CashDepositView
    {
        public CashDeposit CashDeposit { get; set; }
    }

    [AutoMap(typeof(CashDepositDto))]
    [Table("M_POSCashDeposit")]
    public class CashDeposit : FullAuditedEntity<Guid>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string AppCode { get; set; }
        [StringLength(6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string StoreNo { get; set; }
        [StringLength(30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string PosCashId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public DateTime EntryDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int LineNo { get; set; }
        [StringLength(15)]
        public string DenominationCode { get; set; }
        public decimal Denomination { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        [StringLength(8)]
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}


