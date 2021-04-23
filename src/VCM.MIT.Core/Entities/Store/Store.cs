using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VCM.MIT.Data.Entities.Store;

namespace VCM.MIT.Entities.Store
{
    [AutoMap(typeof(StoreViewDto))]
    [NotMapped]
    public class StoreView
    {
        public Store Store { get; set; }
    }

    [AutoMap(typeof(StoreDto))]
    [Table("M_Store")]
    public class Store : FullAuditedEntity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [StringLength(6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string StoreNo { get; set; }
        [StringLength(MITConsts.MaxTitleLength)]
        public string StoreName { get; set; }
        [StringLength(10)]
        public string LocationCode { get; set; }
        [StringLength(MITConsts.MaxTitleLength)]
        public string Address1 { get; set; }
        [StringLength(MITConsts.MaxTitleLength)]
        public string Address2 { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(20)]
        public string PostCode { get; set; }
        [StringLength(20)]
        public string CountryCode { get; set; }
        [StringLength(20)]
        public string StoreManagerID { get; set; }
        [StringLength(100)]
        public string EmailAddress { get; set; }
        [StringLength(50)]
        public string TaxCode { get; set; }
        [StringLength(50)]
        public string BranchNo { get; set; }
        public DateTime StoreOpenfrom { get; set; }
        public DateTime StoreOpento { get; set; }
        [StringLength(10)]
        public string CurrencyCode { get; set; }
        public int StoreOpenAfterMidnight { get; set; }
        [StringLength(50)]
        public string FunctionalityProfile { get; set; }
        [StringLength(50)]
        public string MenuProfile { get; set; }
        [StringLength(50)]
        public string InterfaceProfile { get; set; }
        [StringLength(50)]
        public string StyleProfile { get; set; }
        [StringLength(50)]
        public string HardwareProfile { get; set; }
        [StringLength(50)]
        public string StatementNos { get; set; }
        public int OneStatementPerDay { get; set; }
        public int StatementMethod { get; set; }
        public int ClosingMethod { get; set; }
        [StringLength(50)]
        public string RoundingAccount { get; set; }
        [StringLength(50)]
        public string TotalDiscountTender { get; set; }
        [StringLength(100)]
        public string PrintReceiptLogo { get; set; }
        public int PrintReceiptBitmapNo { get; set; }
        public int ItemNoOnReceipt { get; set; }
        public int ForEvent { get; set; }
        [StringLength(50)]
        public string InfocodeAdjustBill { get; set; }
        [StringLength(50)]
        public string InfocodeAdjustLine { get; set; }
        [StringLength(50)]
        public string CustomerDefault { get; set; }
        [StringLength(50)]
        public string ResponsibilityCenter { get; set; }
        public DateTime LastDateModified { get; set; }
    }
}
