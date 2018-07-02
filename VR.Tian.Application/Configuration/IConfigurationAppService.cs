using System.Threading.Tasks;
using Abp.Application.Services;
using VR.Tian.Configuration.Dto;

namespace VR.Tian.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}