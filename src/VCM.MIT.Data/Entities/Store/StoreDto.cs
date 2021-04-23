using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCM.MIT.Data.Entities.Store
{
    public class StoreDto : EntityDto<int>
    {
        public string StoreNo { get; set; }
        public string StoreName { get; set; }
        public string LocationCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string CountryCode { get; set; }
        public string StoreManagerID { get; set; }
        public string EmailAddress { get; set; }
        public string TaxCode { get; set; }
        public string BranchNo { get; set; }
        public DateTime StoreOpenfrom { get; set; }
        public DateTime StoreOpento { get; set; }
        public string CurrencyCode { get; set; }
        public int StoreOpenAfterMidnight { get; set; }
        public string FunctionalityProfile { get; set; }
        public string MenuProfile { get; set; }
        public string InterfaceProfile { get; set; }
        public string StyleProfile { get; set; }
        public string HardwareProfile { get; set; }
        public string StatementNos { get; set; }
        public int OneStatementPerDay { get; set; }
        public int StatementMethod { get; set; }
        public int ClosingMethod { get; set; }
        public string RoundingAccount { get; set; }
        public string TotalDiscountTender { get; set; }
        public string PrintReceiptLogo { get; set; }
        public int PrintReceiptBitmapNo { get; set; }
        public int ItemNoOnReceipt { get; set; }
        public int ForEvent { get; set; }
        public string InfocodeAdjustBill { get; set; }
        public string InfocodeAdjustLine { get; set; }
        public string CustomerDefault { get; set; }
        public string ResponsibilityCenter { get; set; }
        public DateTime LastDateModified { get; set; }
    }
    public class StoreViewDto
    {
        public StoreDto Item { get; set; }
    }
    public class StoreFilterDto:StoreDto
    {
    }

    public class CreateStoreDto : StoreDto
    {

    }
}
