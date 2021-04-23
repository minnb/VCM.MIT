using Abp.Application.Services;
using VCM.MIT.MultiTenancy.Dto;

namespace VCM.MIT.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

