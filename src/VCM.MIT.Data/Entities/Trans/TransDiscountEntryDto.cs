using System;
using Abp.Application.Services.Dto;


namespace VCM.MIT.Data.Entities.Trans
{
    public class TransDiscountEntryDto : FullAuditedEntityDto<Guid>
    {
		public new Guid? Id { get; set; }
		public string OrderNo { get; set; }
		public int LineNo_ { get; set; }
		public int OrderLineNo { get; set; }
		public string OfferNo { get; set; }
		public string OfferType { get; set; }
		public decimal Qty { get; set; }
		public int DiscountType { get; set; }
		public decimal DiscountAmount { get; set; }
		public int ParentLineNo { get; set; }
		public string ItemNo { get; set; }
		public string LineGroup { get; set; }
	}
	public class TransDiscountEntryViewDto
	{
		public TransPaymentEntryDto TransDiscountEntryDto { get; set; }
	}
	public class CreateTransDiscountEntryDto : TransDiscountEntryDto
	{

	}
	public class TransDiscountEntryFilterDto : TransDiscountEntryDto
	{
	}
}
