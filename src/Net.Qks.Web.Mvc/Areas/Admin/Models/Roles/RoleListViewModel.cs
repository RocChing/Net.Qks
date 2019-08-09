using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.Roles
{
    public class RoleListViewModel
    {
        public List<ComboboxItemDto> Permissions { get; set; }
    }
}