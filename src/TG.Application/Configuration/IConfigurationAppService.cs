using System.Threading.Tasks;
using TG.Configuration.Dto;

namespace TG.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
