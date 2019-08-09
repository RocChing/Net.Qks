using System.Threading.Tasks;
using Abp.Application.Services;
using Net.Qks.Install.Dto;

namespace Net.Qks.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}