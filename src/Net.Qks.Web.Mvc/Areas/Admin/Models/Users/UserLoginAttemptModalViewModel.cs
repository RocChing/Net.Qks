using System.Collections.Generic;
using Net.Qks.Authorization.Users.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}