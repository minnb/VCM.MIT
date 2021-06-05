using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VCM.MIT.Models.Trans
{
    public class TransPaymentEntryModel
    {
		[Required]
		[Display(Name = "Date")]
		[DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
		[DataType(DataType.Date)]
		public DateTime PaymentDate { get; set;}

		[Required]
		public int LineNo { get; set; }
		[Required]
		public string CashierID { get; set; }
		[Required]
		public string TenderType { get; set; }
		[Required]
		public decimal ExchangeRate { get; set; }
		[Required]
		public decimal PaymentAmount { get; set; }
		public string VoucherNo { get; set; }
	}
}
