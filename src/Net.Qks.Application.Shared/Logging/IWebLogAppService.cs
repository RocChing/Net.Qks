using Abp.Application.Services;
using Net.Qks.Dto;
using Net.Qks.Logging.Dto;

namespace Net.Qks.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
