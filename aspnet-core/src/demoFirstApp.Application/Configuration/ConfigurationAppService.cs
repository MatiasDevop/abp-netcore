using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using demoFirstApp.Configuration.Dto;

namespace demoFirstApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : demoFirstAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
