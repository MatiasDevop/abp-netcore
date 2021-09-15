using System.Threading.Tasks;
using demoFirstApp.Configuration.Dto;

namespace demoFirstApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
