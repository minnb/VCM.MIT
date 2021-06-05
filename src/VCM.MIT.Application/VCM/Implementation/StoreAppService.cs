using Abp.Application.Services;
using Abp.Domain.Repositories;
using VCM.MIT.Data.Entities.Store;
using VCM.MIT.Entities.Store;
using VCM.MIT.VCM.Interfaces;

namespace VCM.MIT.VCM.Implementation
{
    public class StoreAppService : AsyncCrudAppService<Store, StoreDto, int, StoreFilterDto>, IStoreAppService
    {
        private readonly IRepository<Store, int> _storeRepository;
        public StoreAppService(IRepository<Store, int> repository)
         : base(repository)
        {
            _storeRepository = repository;
        }
    }
}
