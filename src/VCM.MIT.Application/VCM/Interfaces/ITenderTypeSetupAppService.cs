using Abp.Application.Services;
using System;
using VCM.MIT.Data.Entities.Tender;

namespace VCM.MIT.VCM.Interfaces
{
    public interface ITenderTypeSetupAppService : IAsyncCrudAppService<TenderTypeSetupDto, int, TenderTypeSetupFilterDto, TenderTypeSetupDto, TenderTypeSetupDto>
    {

    }
}

