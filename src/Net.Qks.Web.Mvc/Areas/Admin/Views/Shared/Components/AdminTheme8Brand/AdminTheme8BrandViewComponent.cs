using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Net.Qks.Web.Areas.Admin.Models.Layout;
using Net.Qks.Web.Session;
using Net.Qks.Web.Views;

namespace Net.Qks.Web.Areas.Admin.Views.Shared.Components.AdminTheme8Brand
{
    public class AdminTheme8BrandViewComponent : QksViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AdminTheme8BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
