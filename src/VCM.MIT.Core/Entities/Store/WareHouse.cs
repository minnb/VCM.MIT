using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Store;

namespace VCM.MIT.Data.Entities
{
    [AutoMap(typeof(WareHouseViewDto))]
    [NotMapped]
    public class WareHouseView
    {
        public WareHouse WareHouse { get; set; }
    }

    [AutoMap(typeof(WareHouseDto))]
    [Table("M_StoreWareHouse")]
    public class WareHouse : FullAuditedEntity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string AppCode { get; set; }
        [StringLength(6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string WareHouseCode { get; set; }
        [StringLength(150)]
        public string WareHouseName { get; set; }
        [Required]
        [StringLength(6)]
        public string StoreNo { get; set; }
        [Required]
        public bool Blocked { get; set; } = false;
    }
}
