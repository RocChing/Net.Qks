﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Net.Qks.Configuration.Host.Dto;

namespace Net.Qks.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
