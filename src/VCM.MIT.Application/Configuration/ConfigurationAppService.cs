using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using VCM.MIT.Configuration.Dto;

namespace VCM.MIT.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MITAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
