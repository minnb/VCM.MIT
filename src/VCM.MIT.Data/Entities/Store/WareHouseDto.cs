using Abp.Application.Services.Dto;
using System;

namespace VCM.MIT.Data.Entities.Store
{
    public class WareHouseDto : EntityDto<int>
    {
        public string AppCode { get; set; }
        public string WareHouseCode { get; set; }
        public string WareHouseName { get; set; }
        public string StoreNo { get; set; }
        public bool Blocked { get; set; }

    }
    public class WareHouseViewDto
    {
        public WareHouseDto WareHouseDto { get; set; }
    }
    public class WareHouseFilterDto : WareHouseDto
    {
    }
    public class WareHouseStoreDto : WareHouseDto
    {

    }
}
