using System.Threading.Tasks;
using Abp.Application.Services;
using DemoProject.Sessions.Dto;

namespace DemoProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
