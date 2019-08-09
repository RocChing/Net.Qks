using Abp.AutoMapper;
using Net.Qks.MultiTenancy.Dto;

namespace Net.Qks.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}