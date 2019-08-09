using Abp.AutoMapper;
using Net.Qks.MultiTenancy;
using Net.Qks.MultiTenancy.Dto;
using Net.Qks.Web.Areas.Admin.Models.Common;

namespace Net.Qks.Web.Areas.Admin.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant/*, GetTenantFeaturesEditOutput output*/)
        {
            Tenant = tenant;
            //output.MapTo(this);
        }
    }
}