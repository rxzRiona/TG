using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TG.MultiTenancy.Dto;

namespace TG.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
