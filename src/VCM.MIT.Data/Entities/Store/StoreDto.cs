using Abp.Application.Services.Dto;
using System;

namespace VCM.MIT.Data.Entities.Store
{
    public class StoreDto : EntityDto<int>
    {
        public string StoreNo { get; set; }
        public string StoreName { get; set; }
        public string LocationCode { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string EmailAddress { get; set; }
        public string RegionCode { get; set; }
        public int NoOfPOSConnected { get; set; }
        public string MerchCd { get; set; }
        public string TaxID { get; set; }
        public bool Blocked { get; set; }

    }
    public class StoreViewDto
    {
        public StoreDto StoreDto { get; set; }
    }
    public class StoreFilterDto: StoreDto
    {
    }
    public class CreateStoreDto : StoreDto
    {

    }
}
