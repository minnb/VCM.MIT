using Abp.Application.Services;
using System;
using VCM.MIT.Data.Entities.Trans;

namespace VCM.MIT.VCM.Interfaces
{
    public interface ITransHeaderAppService : IAsyncCrudAppService<TransHeaderDto, Guid, TransHeaderFilterDto, TransHeaderDto, TransHeaderDto>
    {

    }
}
