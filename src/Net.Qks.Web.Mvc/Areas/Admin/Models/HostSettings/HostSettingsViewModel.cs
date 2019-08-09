﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Net.Qks.Configuration.Host.Dto;
using Net.Qks.Editions.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}