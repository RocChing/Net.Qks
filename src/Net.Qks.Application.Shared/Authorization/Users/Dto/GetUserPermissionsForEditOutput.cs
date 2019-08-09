using System.Collections.Generic;
using Net.Qks.Authorization.Permissions.Dto;

namespace Net.Qks.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}