using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TG.Configuration.Dto;

namespace TG.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TGAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
