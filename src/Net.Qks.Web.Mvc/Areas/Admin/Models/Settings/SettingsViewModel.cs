﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Net.Qks.Configuration.Tenants.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}