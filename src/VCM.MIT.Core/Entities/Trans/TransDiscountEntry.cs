using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Trans;

namespace VCM.MIT.Entities.Trans
{
	[AutoMap(typeof(TransDiscountEntryViewDto))]
	[NotMapped]
	public class TransDiscountEntryView
	{
		public TransDiscountEntry TransDiscountEntry { get; set; }
	}

	[AutoMap(typeof(TransDiscountEntryDto))]
	[Table("M_TransDiscountEntry")]
	public class TransDiscountEntry : FullAuditedEntity<Guid>
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public override Guid Id { get; set; }
		[StringLength(MITConsts.OrderNoStringLength)]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Key]
		public string OrderNo { get; set; }
		[Key]
		public int LineNo_ { get; set; }
		public int OrderLineNo { get; set; }
		[StringLength(MITConsts.OrderNoStringLength)]
		public string OfferNo { get; set; }
		[StringLength(10)]
		public string OfferType { get; set; }
		public decimal Qty { get; set; }
		public int DiscountType { get; set; }
		public decimal DiscountAmount { get; set; }
		public int ParentLineNo { get; set; }
		[StringLength(MITConsts.ItemNoStringLength)]
		public string ItemNo { get; set; }
		public string LineGroup { get; set; }
	}
}
