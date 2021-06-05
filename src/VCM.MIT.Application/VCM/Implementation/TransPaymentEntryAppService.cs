using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Threading.Tasks;
using VCM.MIT.Data.Entities.Item;
using VCM.MIT.Data.Entities.Trans;
using VCM.MIT.Entities;
using VCM.MIT.VCM.Interfaces;

namespace VCM.MIT.VCM.Implementation
{
    public class TransPaymentEntryAppService : AsyncCrudAppService<TransPaymentEntry, TransPaymentEntryDto, Guid, TransPaymentEntryDto>, ITransPaymentEntryAppService
    {
        private readonly IRepository<TransPaymentEntry, Guid> _transPaymentEntryRepository;
        public TransPaymentEntryAppService(IRepository<TransPaymentEntry, Guid> repository)
         : base(repository)
        {
            _transPaymentEntryRepository = repository;
        }

        public Task<PagedResultDto<TransPaymentEntryDto>> GetAllAsync(TransPaymentEntryFilterDto input)
        {
            throw new NotImplementedException();
        }

         
    }
}
