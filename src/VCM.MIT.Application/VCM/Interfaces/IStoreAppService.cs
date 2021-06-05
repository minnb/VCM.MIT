using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCM.MIT.Data.Entities.Item;
using VCM.MIT.Data.Entities.Store;

namespace VCM.MIT.VCM.Interfaces
{
    public interface IStoreAppService : IAsyncCrudAppService<StoreDto, int, StoreFilterDto>
    {

    }
}
