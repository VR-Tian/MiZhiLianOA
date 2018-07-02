using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VR.Tian.MultiTenancy.Dto;

namespace VR.Tian.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
