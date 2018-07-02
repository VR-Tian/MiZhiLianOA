using System.Threading.Tasks;
using Abp.Application.Services;
using VR.Tian.Sessions.Dto;

namespace VR.Tian.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
