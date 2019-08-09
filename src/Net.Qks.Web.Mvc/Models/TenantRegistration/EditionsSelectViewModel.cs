using Abp.AutoMapper;
using Net.Qks.MultiTenancy.Dto;

namespace Net.Qks.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
        public EditionsSelectViewModel(/*EditionsSelectOutput output*/)
        {
            //output.MapTo(this);
        }
    }
}
