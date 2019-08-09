using Abp.AutoMapper;
using Net.Qks.Authorization.Users;
using Net.Qks.Authorization.Users.Dto;
using Net.Qks.Web.Areas.Admin.Models.Common;

namespace Net.Qks.Web.Areas.Admin.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }

        public UserPermissionsEditViewModel(/*GetUserPermissionsForEditOutput output, User user*/)
        {
            //User = user;
            //output.MapTo(this);
        }
    }
}