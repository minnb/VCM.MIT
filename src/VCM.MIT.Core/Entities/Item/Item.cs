using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Item;


namespace VCM.MIT.Entities
{
    [AutoMap(typeof(ItemViewDto))]
    [NotMapped]
    public class ItemView
    {
        public Item Item { get; set; }
    }

    [AutoMap(typeof(ItemDto))]
    [Table("M_Item")]
    public class Item : FullAuditedEntity<long>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }

        [StringLength(18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string ItemNo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [StringLength(10)]
        public string AppCode { get; set; }

        public string PluCode { get; set; }
        [StringLength(MITConsts.MaxTitleLength)]
        public string ItemName { get; set; }
        [StringLength(MITConsts.MaxTitleLength)]
        public string SearchDescription { get; set; }
        [StringLength(MITConsts.MaxDescriptionLength)]
        public string LongDescription { get; set; }
        public int Blocked { get; set; }
        public int Critical { get; set; }
        public int TaxGroupCode { get; set; }
        [StringLength(MITConsts.UOMStringLength)]
        public string BaseUOM { get; set; }
        [StringLength(MITConsts.UOMStringLength)]
        public string SalesUOM { get; set; }
        public decimal UnitPrice { get; set; }
        public int CostingMethod { get; set; }
        public decimal UnitCost { get; set; }
        public decimal StandardCost { get; set; }
        [StringLength(20)]
        public string VendorNo { get; set; }
        [StringLength(20)]
        public string VendorItemNo { get; set; }
        public decimal MaximumInventory { get; set; }
        public decimal ReorderQuantity { get; set; }
        public decimal GrossWeight { get; set; }
        public decimal NetWeight { get; set; }
        public decimal UnitVolume { get; set; }
        public int PriceIncludesVAT { get; set; }
        public decimal MinimumOrderQuantity { get; set; }
        public decimal MaximumOrderQuantity { get; set; }
        public decimal SafetyStockQuantity { get; set; }
        public decimal OrderMultiple { get; set; }
        [StringLength(50)]
        public string ManufacturerCode { get; set; }
        [StringLength(50)]
        public string ItemCategoryCode { get; set; }
        [StringLength(50)]
        public string ProductGroupCode { get; set; }
        [StringLength(50)]
        public string ServiceItemGroup { get; set; }
        [StringLength(50)]
        public string ItemTrackingCode { get; set; }
        [StringLength(50)]
        public string ProductionBOMNo { get; set; }
        [StringLength(50)]
        public string DivisionCode { get; set; }
        public int StatisticsGroup { get; set; }
        public int CommissionGroup { get; set; }
        public DateTime LastDateModified { get; set; }
    }
}
