using System.Threading.Tasks;
using Abp.Application.Services;
using VR.Tian.Authorization.Accounts.Dto;

namespace VR.Tian.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
