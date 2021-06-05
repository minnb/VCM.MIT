using Abp.Application.Services;
using System;
using VCM.MIT.Data.Entities.Trans;

namespace VCM.MIT.VCM.Interfaces
{
    public interface ITransPaymentEntryAppService : IAsyncCrudAppService<TransPaymentEntryDto, Guid, TransPaymentEntryFilterDto, TransPaymentEntryDto, TransPaymentEntryDto>
    {

    }
}
