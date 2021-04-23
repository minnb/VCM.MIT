using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Tender;

namespace VCM.MIT.Entities.Tender
{
    [AutoMap(typeof(TenderTypeViewDto))]
    [NotMapped]
    public class TenderTypeView
    {
        public TenderType TenderType { get; set; }
    }

    [AutoMap(typeof(TenderTypeDto))]
    [Table("M_TenderType")]
    public class TenderType : FullAuditedEntity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [StringLength(6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string StoreNo { get; set; }
        [StringLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string Code { get; set; }
        [StringLength(MITConsts.MaxTitleLength)]
        public string Description { get; set; }
        public int Function { get; set; }
        [StringLength(20)]
        public string ChangeTenderCode { get; set; }
        public int Rounding { get; set; }
        public decimal RoundingTo { get; set; }
        public decimal MinAmountEntered { get; set; }
        public decimal MaxAmountEntered { get; set; }
        public decimal MinAmountAllowed { get; set; }
        public decimal MaxAmountAllowed { get; set; }
        public bool Used { get; set; }
        public bool ManagerKeyControl { get; set; }
        public bool KeyboardEntryAllowed { get; set; }
        public bool OvertenderAllowed { get; set; }
        public decimal OvertenderMaxAmt { get; set; }
        public bool DrawerOpens { get; set; }
        public bool CardAccountNo { get; set; }
        public bool AskForDate { get; set; }
        public bool ForeignCurrency { get; set; }
        public bool FloatAllowed { get; set; }
        public int BankAccountType { get; set; }
        [StringLength(50)]
        public string BankAccountNo { get; set; }
        [StringLength(MITConsts.MaxTitleLength)]
        public string BankAccountName { get; set; }
        public bool ReturnVoucher { get; set; }
        public string AccountNo { get; set; }
    }
}
