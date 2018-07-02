using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VR.Tian.Roles.Dto;
using VR.Tian.Users.Dto;

namespace VR.Tian.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}