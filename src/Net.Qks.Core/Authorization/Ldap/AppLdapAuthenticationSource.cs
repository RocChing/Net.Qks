using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Net.Qks.Authorization.Users;
using Net.Qks.MultiTenancy;

namespace Net.Qks.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}