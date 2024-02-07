using System.Threading.Tasks;
using DemoProject.Configuration.Dto;

namespace DemoProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
