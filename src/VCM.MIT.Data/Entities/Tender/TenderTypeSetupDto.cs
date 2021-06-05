using Abp.Application.Services.Dto;

namespace VCM.MIT.Data.Entities.Tender
{
    public class TenderTypeSetupDto : FullAuditedEntityDto<int>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool DefaultFunction { get; set; }
        public bool DefaultCardTender { get; set; }
        public bool DefaultCurrencyTender { get; set; }
        public string Caption { get; set; }
        public int SeqOnPOS { get; set; }
        public bool IsInstallmentSell { get; set; }
        public int PaymentMethod { get; set; }
        public string RefKey1 { get; set; }
        public string RefKey2 { get; set; }
        public string CurrencyCode { get; set; }
    }
    public class TenderTypeSetupViewDto
    {
        public TenderTypeSetupDto TenderTypeSetupDto { get; set; }
    }
    public class TenderTypeSetupFilterDto : TenderTypeSetupDto
    {
    }
}

