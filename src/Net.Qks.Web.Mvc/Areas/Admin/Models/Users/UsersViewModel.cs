using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.Users
{
    public class UsersViewModel
    {
        public string FilterText { get; set; }

        public List<ComboboxItemDto> Permissions { get; set; }

        public List<ComboboxItemDto> Roles { get; set; }

        public bool OnlyLockedUsers { get; set; }
    }
}