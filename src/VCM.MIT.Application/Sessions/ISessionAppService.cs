using System.Threading.Tasks;
using Abp.Application.Services;
using VCM.MIT.Sessions.Dto;

namespace VCM.MIT.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
