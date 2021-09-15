using System.Threading.Tasks;
using Abp.Application.Services;
using demoFirstApp.Sessions.Dto;

namespace demoFirstApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
