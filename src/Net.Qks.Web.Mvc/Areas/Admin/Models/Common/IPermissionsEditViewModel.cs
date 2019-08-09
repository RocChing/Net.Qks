using System.Collections.Generic;
using Net.Qks.Authorization.Permissions.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}