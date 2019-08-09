using Abp.AutoMapper;
using Net.Qks.Authorization.Roles.Dto;
using Net.Qks.Web.Areas.Admin.Models.Common;

namespace Net.Qks.Web.Areas.Admin.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode
        {
            get { return Role.Id.HasValue; }
        }

        public CreateOrEditRoleModalViewModel(/*GetRoleForEditOutput output*/)
        {
            //output.MapTo(this);
        }
    }
}