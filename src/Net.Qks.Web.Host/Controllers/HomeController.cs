using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Net.Qks.Web.Controllers
{
    public class HomeController : QksControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Ui");
        }
    }
}
