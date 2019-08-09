using System.Threading.Tasks;
using Abp.Application.Services;
using Net.Qks.Editions.Dto;
using Net.Qks.MultiTenancy.Dto;

namespace Net.Qks.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}