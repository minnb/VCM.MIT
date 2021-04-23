using Abp.Application.Services.Dto;
using System;

namespace VCM.MIT.Data.Entities.Item
{
    public class ItemUOMDto : EntityDto<long>
    {
        public string ItemNo { get; set; }
        public string BaseUOM { get; set; }
        public string SalesUOM { get; set; }
        public decimal QtyPerUOM{ get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Cubage { get; set; }
        public decimal Weight { get; set; }
    }
    public class ItemUOMViewDto
    {
        public ItemUOMDto Item { get; set; }
    }
    public class ItemUOMFilterDto : ItemUOMDto
    {
    }
}
