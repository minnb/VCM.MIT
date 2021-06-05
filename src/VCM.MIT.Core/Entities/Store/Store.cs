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
        [StringLength(200)]
        public string StoreName { get; set; }
        [StringLength(6)]
        public string LocationCode { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [StringLength(20)]
        public string City { get; set; }
        [StringLength(200)]
        public string Address1 { get; set; }
        [StringLength(200)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [StringLength(3)]
        public string RegionCode { get; set; }
        public int NoOfPOSConnected { get; set; }
        [StringLength(20)]
        public string MerchCd { get; set; }
        [StringLength(30)]
        public string TaxID { get; set; }
        [Required]
        public bool Blocked { get; set; } = false;
    }
}
