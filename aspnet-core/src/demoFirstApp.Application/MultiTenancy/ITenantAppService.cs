using Abp.Application.Services;
using demoFirstApp.MultiTenancy.Dto;

namespace demoFirstApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

