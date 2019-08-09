using System.Threading.Tasks;
using Abp.Authorization.Users;
using Net.Qks.Authorization.Users;

namespace Net.Qks.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
