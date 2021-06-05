using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Item;

namespace VCM.MIT.Entities
{
    [AutoMap(typeof(ItemGroupViewDto))]
    [NotMapped]
    public class ItemGroupView
    {
        public ItemGroup ItemGroup { get; set; }
    }

    [AutoMap(typeof(ItemGroupDto))]
    [Table("M_ItemGroup")]
    public class ItemGroup : FullAuditedEntity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string AppCode { get; set; }
        [StringLength(10)]
        public string GroupCode { get; set; }
        [StringLength(200)]
        public string GroupName { get; set; }
        public decimal Profit1 { get; set; }
        public decimal Profit2 { get; set; }
        public decimal Profit3 { get; set; }
        [StringLength(10)]
        public string ExtCode1 { get; set; }
        [StringLength(10)]
        public string ExtCode2 { get; set; }
        [StringLength(10)]
        public string ExtCode3 { get; set; }
        [StringLength(10)]
        public string ExtCode4 { get; set; }
        [StringLength(10)]
        public string ExtCode5 { get; set; }
        public decimal ExtValue1 { get; set; }
        public decimal ExtValue2 { get; set; }
        public decimal ExtValue3 { get; set; }
        public decimal ExtValue4 { get; set; }
        public decimal ExtValue5 { get; set; }
    }
}
