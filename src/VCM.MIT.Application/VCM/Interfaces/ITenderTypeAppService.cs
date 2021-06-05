using Abp.Application.Services;
using System;
using VCM.MIT.Data.Entities.Tender;

namespace VCM.MIT.VCM.Interfaces
{
    public interface ITenderTypeAppService : IAsyncCrudAppService<TenderTypeDto, int, TenderTypeFilterDto, TenderTypeDto, TenderTypeDto>
    {

    }
}

