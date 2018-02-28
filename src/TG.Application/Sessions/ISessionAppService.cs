using System.Threading.Tasks;
using Abp.Application.Services;
using TG.Sessions.Dto;

namespace TG.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
