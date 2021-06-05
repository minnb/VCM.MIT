using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Threading.Tasks;
using VCM.MIT.Data.Entities.Trans;
using VCM.MIT.Entities.Trans;
using VCM.MIT.VCM.Interfaces;

namespace VCM.MIT.VCM.Implementation
{
    public class TransDiscountEntryAppService : AsyncCrudAppService<TransDiscountEntry, TransDiscountEntryDto, Guid, TransDiscountEntryDto>, ITransDiscountEntryAppService
    {
        private readonly IRepository<TransDiscountEntry, Guid> _transDiscountEntryRepository;
        public TransDiscountEntryAppService(IRepository<TransDiscountEntry, Guid> repository)
         : base(repository)
        {
            _transDiscountEntryRepository = repository;
        }

        public Task<PagedResultDto<TransDiscountEntryDto>> GetAllAsync(TransDiscountEntryFilterDto input)
        {
            throw new NotImplementedException();
        }

         
    }
}
