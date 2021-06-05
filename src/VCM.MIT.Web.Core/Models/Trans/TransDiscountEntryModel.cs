using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCM.MIT.Models.Trans
{
    public class TransDiscountEntryModel
    {
		public int LineNo { get; set; }
		public string OfferNo { get; set; }
		public string OfferType { get; set; }
		public string OfferName { get; set; }
		public decimal Qty { get; set; }
		public int DiscountType { get; set; }
		public decimal DiscountAmount { get; set; }
	}
}
