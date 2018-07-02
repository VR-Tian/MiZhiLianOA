using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using VR.Tian.Configuration.Dto;

namespace VR.Tian.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TianAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
