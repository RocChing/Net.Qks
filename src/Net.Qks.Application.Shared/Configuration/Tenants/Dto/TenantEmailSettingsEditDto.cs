using Abp.Auditing;
using Net.Qks.Configuration.Dto;

namespace Net.Qks.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}