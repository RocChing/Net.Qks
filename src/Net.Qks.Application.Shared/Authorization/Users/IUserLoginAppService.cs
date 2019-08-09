using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Net.Qks.Authorization.Users.Dto;

namespace Net.Qks.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
