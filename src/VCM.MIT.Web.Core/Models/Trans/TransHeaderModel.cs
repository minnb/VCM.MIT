using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VCM.MIT.Models.Trans
{
    public class TransHeaderModel
    {
        [Required]
        [StringLength(6, MinimumLength = 6)]
        public string StoreNo { get; set; }
        [Required]
        public string OrderNo { get; set; }
        [Required]
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string ShiftCode { get; set; }
        [Required]
        public string CashierID { get; set; }
        public string PosNo { get; set; }
        public string CustNo { get; set; }
        public string CustName { get; set; }
        public string CustPhone { get; set; }
        public string CustAddress { get; set; }
        [Required]
        public decimal DiscountAmount { get; set; }
        [Required]
        public decimal TotalAmountInclVAT { get; set; }
        public string MemberCardNo { get; set; }
        public decimal MemberPointsEarn { get; set; }
        public decimal MemberPointsRedeem { get; set; }
        [Required]
        public int Returned { get; set; } = 0;
        public string RefOrder { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IssuedVATInvoice { get; set; } = false;
        public string BillNumber { get; set; }
        public string OrderType { get; set; }
        public BillingInfo VATInfo { get; set; }
        [Required]
        public List<TransLineModel> Items { get; set; }
        [Required]
        public List<TransPaymentEntryModel> Payments { get; set; }
    }

    public class BillingInfo
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string TaxCode { get; set; }
    }
}