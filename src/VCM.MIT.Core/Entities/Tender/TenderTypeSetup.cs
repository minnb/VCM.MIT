using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Tender;

namespace VCM.MIT.Entities.Tender
{
    [AutoMap(typeof(TenderTypeSetupViewDto))]
    [NotMapped]
    public class TenderTypeSetupView
    {
        public TenderTypeSetup TenderTypeSetup { get; set; }
    }

    [AutoMap(typeof(TenderTypeSetupDto))]
    [Table("M_TenderTypeSetup")]
    public class TenderTypeSetup : FullAuditedEntity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [StringLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string Code { get; set; }
        [StringLength(MITConsts.MaxTitleLength)]
        public string Description { get; set; }
        public bool DefaultFunction { get; set; }
        public bool DefaultCardTender { get; set; }
        public bool DefaultCurrencyTender { get; set; }
        [StringLength(100)]
        public string Caption { get; set; }
        public int SeqOnPOS { get; set; }
        public bool IsInstallmentSell { get; set; }
        public int PaymentMethod { get; set; }
        [StringLength(50)]
        public string RefKey1 { get; set; }
        [StringLength(50)]
        public string RefKey2 { get; set; }
        [StringLength(20)]
        public string CurrencyCode { get; set; }
    }
}
