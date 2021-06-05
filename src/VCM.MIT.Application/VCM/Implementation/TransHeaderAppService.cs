using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Threading.Tasks;
using VCM.MIT.Data.Entities.Trans;
using VCM.MIT.Entities;
using VCM.MIT.VCM.Interfaces;

namespace VCM.MIT.VCM.Implementation
{
    public class TransHeaderAppService : AsyncCrudAppService<TransHeader, TransHeaderDto, Guid, TransHeaderDto>, ITransHeaderAppService
    {
        private readonly IRepository<TransHeader, Guid> _transHeaderRepository;
        public TransHeaderAppService(IRepository<TransHeader, Guid> repository)
         : base(repository)
        {
            _transHeaderRepository = repository;
        }

        public Task<PagedResultDto<TransHeaderDto>> GetAllAsync(TransHeaderFilterDto input)
        {
            throw new NotImplementedException();
        }

         
    }
}
