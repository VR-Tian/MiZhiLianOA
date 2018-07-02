using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VR.Tian.Roles.Dto;

namespace VR.Tian.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
