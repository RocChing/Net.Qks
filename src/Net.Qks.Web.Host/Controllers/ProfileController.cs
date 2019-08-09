using Abp.AspNetCore.Mvc.Authorization;
using Net.Qks.Storage;

namespace Net.Qks.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(ITempFileCacheManager tempFileCacheManager) :
            base(tempFileCacheManager)
        {
        }
    }
}