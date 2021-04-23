using Abp.Application.Services.Dto;
using System;

namespace VCM.MIT.Data.Entities.Item
{
    public class ItemDto : EntityDto<long>
    {
        public string AppCode { get; set; }
        public string ItemNo { get; set; }
        public string PluCode { get; set; }
        public string ItemName { get; set; }
        public string SearchDescription { get; set; }
        public string LongDescription { get; set; }
        public int Blocked { get; set; }
        public int Critical { get; set; }
        public string TaxGroupCode { get; set; }
        public string BaseUOM { get; set; }
        public string SalesUOM { get; set; }
        public decimal UnitPrice { get; set; }
        public int CostingMethod { get; set; }
        public decimal UnitCost { get; set; }
        public decimal StandardCost { get; set; }
        public string VendorNo { get; set; }
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
        public string ManufacturerCode { get; set; }
        public string ItemCategoryCode { get; set; }
        public string ProductGroupCode { get; set; }
        public string ServiceItemGroup { get; set; }
        public string ItemTrackingCode { get; set; }
        public string ProductionBOMNo { get; set; }
        public string DivisionCode { get; set; }
        public int StatisticsGroup { get; set; }
        public int CommissionGroup { get; set; }
        public DateTime LastDateModified { get; set; }

    }
    public class ItemViewDto
    {
        public ItemDto ItemDto { get; set; }
    }
    public class ItemFilterDto: ItemDto
    {
    }
}
