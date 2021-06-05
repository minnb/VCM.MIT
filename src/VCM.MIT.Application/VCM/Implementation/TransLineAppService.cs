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
    public class TransLineAppService : AsyncCrudAppService<TransLine, TransLineDto, Guid, TransLineDto>, ITransLineAppService
    {
        private readonly IRepository<TransLine, Guid> _transLineRepository;
        public TransLineAppService(IRepository<TransLine, Guid> repository)
         : base(repository)
        {
            _transLineRepository = repository;
        }

        public Task<PagedResultDto<TransLineDto>> GetAllAsync(TransLineFilterDto input)
        {
            throw new NotImplementedException();
        }

         
    }
}
