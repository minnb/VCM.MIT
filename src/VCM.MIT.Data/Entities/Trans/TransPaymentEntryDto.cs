using Abp.Application.Services.Dto;
using System;

namespace VCM.MIT.Data.Entities.Trans
{
    public class TransPaymentEntryDto : FullAuditedEntityDto<Guid>
	{
		public new Guid? Id { get; set; }
		public string OrderNo { get; set; }
		public DateTime PaymentDate { get; set; }
		public int LineNo_ { get; set; }
		public string StoreNo { get; set; }
		public string PosNo { get; set; }
		public string ShiftCode { get; set; }
		public string CashierID { get; set; }
		public string TenderType { get; set; }
		public decimal ExchangeRate { get; set; }
		public decimal AmountTendered { get; set; }
		public string CurrencyCode { get; set; }
		public decimal AmountInCurrency { get; set; }
		public int CardPaymentType { get; set; }
		public decimal CardValue { get; set; }
		public string ReferenceNo { get; set; }
		public string PayForOrderNo { get; set; }
		public string TransactionNo { get; set; }
	}
	public class TransPaymentEntryViewDto
	{
		public TransPaymentEntryDto TransPaymentEntryDto { get; set; }
	}
	public class CreateTransPaymentEntryDto : TransPaymentEntryDto
	{

	}
	public class TransPaymentEntryFilterDto : TransPaymentEntryDto
	{
	}
}
