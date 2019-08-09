using Abp.Authorization;
using Net.Qks.Authorization.Roles;
using Net.Qks.Authorization.Users;

namespace Net.Qks.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
