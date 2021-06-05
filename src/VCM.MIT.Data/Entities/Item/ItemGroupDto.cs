using Abp.Application.Services.Dto;
using System;

namespace VCM.MIT.Data.Entities.Item
{
    public class ItemGroupDto : EntityDto<int>
    {
        public string AppCode { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public decimal Profit1 { get; set; }
        public decimal Profit2 { get; set; }
        public decimal Profit3 { get; set; }
        public string ExtCode1 { get; set; }
        public string ExtCode2 { get; set; }
        public string ExtCode3 { get; set; }
        public string ExtCode4 { get; set; }
        public string ExtCode5 { get; set; }
        public decimal ExtValue1 { get; set; }
        public decimal ExtValue2 { get; set; }
        public decimal ExtValue3 { get; set; }
        public decimal ExtValue4 { get; set; }
        public decimal ExtValue5 { get; set; }
    }
    public class ItemGroupViewDto
    {
        public ItemGroupDto ItemGroupDto { get; set; }
    }
    public class ItemGroupFilterDto : ItemGroupDto
    {
    }
}
