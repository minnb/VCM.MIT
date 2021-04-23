using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Item;

namespace VCM.MIT.Entities
{
    [AutoMap(typeof(ItemUOMViewDto))]
    [NotMapped]
    public class ItemUOMView
    {
        public ItemUOM ItemUOM { get; set; }
    }

    [AutoMap(typeof(ItemUOMDto))]
    [Table("M_ItemUOM")]
    public class ItemUOM : FullAuditedEntity<long>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }

        [StringLength(MITConsts.ItemNoStringLength)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string ItemNo { get; set; }
        [StringLength(MITConsts.UOMStringLength)]
        public string BaseUOM { get; set; }
        [StringLength(MITConsts.UOMStringLength)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string SalesUOM { get; set; }
        public decimal QtyPerUOM { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Cubage { get; set; }
        public decimal Weight { get; set; }
    }
}
