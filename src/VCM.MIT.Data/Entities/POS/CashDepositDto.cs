using Abp.Application.Services.Dto;
using System;


namespace VCM.MIT.Data.Entities
{
    public class CashDepositDto : EntityDto<Guid>
    {
        public string AppCode { get; set; }
        public string StoreNo { get; set; }
        public string PosCashId { get; set; }
        public DateTime EntryDate { get; set; }
        public int LineNo { get; set; }
        public string DenominationCode { get; set; }
        public decimal Denomination { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class CashDepositViewDto
    {
        public CashDepositDto CashDepositDto { get; set; }
    }
    public class CashDepositFilterDto : CashDepositDto
    {
    }
}


