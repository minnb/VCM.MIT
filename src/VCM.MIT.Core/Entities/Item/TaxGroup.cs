using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Item;

namespace VCM.MIT.Entities
{
    [AutoMap(typeof(TaxGroupViewDto))]
    [NotMapped]
    public class TaxGroupView
    {
        public TaxGroup TaxGroup { get; set; }
    }

    [AutoMap(typeof(TaxGroupDto))]
    [Table("M_ItemTaxGroup")]
    public class TaxGroup : FullAuditedEntity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string AppCode { get; set; }
        [StringLength(10)]
        public string TaxCode { get; set; }
        public decimal VATPercent { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
    }
}
