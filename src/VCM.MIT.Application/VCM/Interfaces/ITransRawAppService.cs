using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VCM.MIT.Data.Entities.Trans;
using VCM.MIT.Entities;

namespace VCM.MIT.VCM.Interfaces
{
    public interface ITransRawAppService : IAsyncCrudAppService<TransRawDto, Guid, TransRawFilterDto, TransRawDto, TransRawDto>
    {
        Task<List<TransRaw>> GetTransRawN(string updateFlg);
        bool UpdateFlgTransRaw(Guid id, string updateFlg);
    }
}

