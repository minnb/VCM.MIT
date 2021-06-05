using Abp.Application.Services.Dto;

namespace VCM.MIT.Data.Entities.Tender
{
    public class TenderTypeDto : FullAuditedEntityDto<int>
    {
        public string StoreNo { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Function { get; set; }
        public string ChangeTenderCode { get; set; }
        public int Rounding { get; set; }
        public decimal RoundingTo { get; set; }
        public decimal MinAmountEntered { get; set; }
        public decimal MaxAmountEntered { get; set; }
        public decimal MinAmountAllowed { get; set; }
        public decimal MaxAmountAllowed { get; set; }
        public bool Used { get; set; }
        public bool ManagerKeyControl { get; set; }
        public bool KeyboardEntryAllowed { get; set; }
        public bool OvertenderAllowed { get; set; }
        public decimal OvertenderMaxAmt { get; set; }
        public bool DrawerOpens { get; set; }
        public bool CardAccountNo { get; set; }
        public bool AskForDate { get; set; }
        public bool ForeignCurrency { get; set; }
        public bool FloatAllowed { get; set; }
        public int BankAccountType { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAccountName { get; set; }
        public bool ReturnVoucher { get; set; }
        public string AccountNo { get; set; }
    }
    public class TenderTypeViewDto
    {
        public TenderTypeDto TenderTypeDto { get; set; }
    }
    public class TenderTypeFilterDto : TenderTypeDto
    {
    }
}
