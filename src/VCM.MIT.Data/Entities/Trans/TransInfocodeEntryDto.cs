using System;
using Abp.Application.Services.Dto;

namespace VCM.MIT.Data.Entities.Trans
{
    public class TransInfocodeEntryDto : FullAuditedEntityDto<Guid>
    {
		public new Guid? Id { get; set; }
		public string OrderNo { get; set; }
		public int LineNo_ { get; set; }
		public int OrderLineNo { get; set; }
		public int TransactionType { get; set; }
		public string Infocode { get; set; }
		public string Infomation { get; set; }
		public int TypeOfInput { get; set; }
		public int TextType { get; set; }
		public string ItemNo { get; set; }
		public string SourceCode { get; set; }
		public decimal Amount { get; set; }
		public string SubCode { get; set; }
		public int ParentLineNo { get; set; }
		public string Options { get; set; }
	}
	public class TransInfocodeEntryViewDto
	{
		public TransInfocodeEntryDto TransInfocodeEntryDto { get; set; }
	}
	public class CreateTransInfocodeEntryDto : TransInfocodeEntryDto
	{

	}
	public class TransInfocodeEntryFilterDto : TransInfocodeEntryDto
	{
	}
}
