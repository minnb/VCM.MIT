using System.Threading.Tasks;
using VCM.MIT.Configuration.Dto;

namespace VCM.MIT.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
