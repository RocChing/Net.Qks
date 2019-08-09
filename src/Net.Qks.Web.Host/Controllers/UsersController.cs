using Abp.AspNetCore.Mvc.Authorization;
using Net.Qks.Authorization;
using Net.Qks.Storage;
using Abp.BackgroundJobs;

namespace Net.Qks.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}