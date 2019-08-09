using System.Threading.Tasks;
using Abp.Application.Services;
using Net.Qks.Sessions.Dto;

namespace Net.Qks.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
