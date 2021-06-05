using Abp.Application.Services;
using Abp.Domain.Repositories;
using VCM.MIT.Data.Entities.Item;
using VCM.MIT.Entities;
using VCM.MIT.VCM.Interfaces;

namespace VCM.MIT.VCM.Implementation
{
    public class ItemUOMAppService : AsyncCrudAppService<ItemUOM, ItemUOMDto, long, ItemUOMFilterDto>, IItemUOMAppService
    {
        private readonly IRepository<ItemUOM, long> _itemUOMRepository;
        public ItemUOMAppService(IRepository<ItemUOM, long> repository)
         : base(repository)
        {
            _itemUOMRepository = repository;
        }
    }
}
