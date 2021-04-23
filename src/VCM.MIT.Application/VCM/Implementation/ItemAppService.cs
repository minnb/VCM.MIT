using Abp.Application.Services;
using Abp.Domain.Repositories;
using VCM.MIT.Data.Entities.Item;
using VCM.MIT.Entities;
using VCM.MIT.VCM.Interfaces;

namespace VCM.MIT.VCM.Implementation
{
    public class ItemAppService : AsyncCrudAppService<Item, ItemDto, long, ItemFilterDto>, IItemAppService
    {
        private readonly IRepository<Item, long> _ItemRepository;
        public ItemAppService(IRepository<Item, long> repository)
         : base(repository)
        {
            _ItemRepository = repository;
        }
    }
}
