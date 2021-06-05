using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities;

namespace VCM.MIT.Data.Entities
{
	[AutoMap(typeof(EndOfDayViewDto))]
	[NotMapped]
	public class EndOfDayView
	{
		public EndOfDay EndOfDay { get; set; }
	}

	[AutoMap(typeof(EndOfDayDto))]
	[Table("M_POSEndOfDay")]
	public class EndOfDay : FullAuditedEntity<long>
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public override long Id { get; set; }
		[StringLength(10)]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Key]
		public string AppCode { get; set; }
		[StringLength(6)]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Key]
		public string StoreNo { get; set; }
		public DateTime EntryDate { get; set; }
		public int MerchandiseSalesCust { get; set; }
		public int MerchandiseSalesQty { get; set; }
		public decimal MerchandiseSalesAmount { get; set; }
		public decimal TaxablesSalesAmount { get; set; }
		public int NonTaxSalesQty { get; set; }
		public decimal NonTaxSalesAmoun { get; set; }
		public int ReturnMerchandiseCust { get; set; }
		public int ReturnMerchandiseQty { get; set; }
		public decimal ReturnMerchandiseAmount { get; set; }
		public int RetunTaxablesQty { get; set; }
		public decimal RetunTaxablesAmount { get; set; }
		public int ReturnNonTaxQty { get; set; }
		public decimal ReturnNonTaxAmoun { get; set; }
		public decimal BeginingCashAmount { get; set; }
		public decimal TotalAmount { get; set; }
		public decimal CashAmount { get; set; }
		public decimal BankAmount { get; set; }
		public decimal ReturnVouche { get; set; }
		public decimal Voucher { get; set; }
		public decimal MemberPoint { get; set; }
		public decimal PayExceed { get; set; }
		public decimal QRPayment { get; set; }
		public decimal PrepaidCard { get; set; }
	}
}
