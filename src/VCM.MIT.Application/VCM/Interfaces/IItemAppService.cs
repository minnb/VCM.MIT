using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCM.MIT.Data.Entities.Item;

namespace VCM.MIT.VCM.Interfaces
{
    public interface IItemAppService : IAsyncCrudAppService<ItemDto, long, ItemFilterDto>
    {

    }
}
