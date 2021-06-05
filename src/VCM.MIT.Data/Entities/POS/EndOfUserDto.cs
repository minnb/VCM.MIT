using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCM.MIT.Data.Entities
{
    public class EndOfUserDto : EntityDto<long>
	{
		public string AppCode { get; set; }
		public string StoreNo { get; set; }
		public string StaffID { get; set; }
		public int ShiftNo { get; set; }
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
		public decimal Drawfoat { get; set; }
		public decimal LogicalCash { get; set; }
		public decimal OverShort { get; set; }
	}
	public class EndOfUserViewDto
	{
		public EndOfUserDto EndOfUserDto { get; set; }
	}
	public class EndOfUserFilterDto : EndOfUserDto
	{
	}
}

