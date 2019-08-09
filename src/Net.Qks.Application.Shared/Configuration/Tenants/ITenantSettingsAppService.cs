using System.Threading.Tasks;
using Abp.Application.Services;
using Net.Qks.Configuration.Tenants.Dto;

namespace Net.Qks.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
