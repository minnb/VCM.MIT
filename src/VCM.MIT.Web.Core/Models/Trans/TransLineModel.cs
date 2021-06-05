using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VCM.MIT.Models.Trans
{
    public class TransLineModel
    {
        [Required]
        public int LineNo { get; set; }
        [Required]      
        public string ItemNo { get; set; }
        public string Barcode { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public string UOM { get; set; }
        [Required]
        [Range(0.0001, 9999.99, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public decimal Qty { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public decimal DiscountAmount { get; set; }
        [Required]
        public string VatGroup { get; set; }
        [Required]
        public decimal VatPercent { get; set; }
        [Required]
        public decimal VatAmount { get; set; }
        [Required]
        public decimal LineAmount { get; set; }
        public string SerialNo { get; set; }
        public List<TransDiscountEntryModel> DiscountEntry { get; set; }
    }
}
