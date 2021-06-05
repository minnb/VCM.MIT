using Abp.Application.Services.Dto;
using System;


namespace VCM.MIT.Data.Entities.Item
{
    public class TaxGroupDto : EntityDto<int>
    {
        public string AppCode { get; set; }
        public string TaxCode { get; set; }
        public decimal VATPercent { get; set; }
        public string Description { get; set; }
    }
    public class TaxGroupViewDto
    {
        public TaxGroupDto TaxGroupDto { get; set; }
    }
    public class TaxGroupFilterDto : TaxGroupDto
    {
    }
}
