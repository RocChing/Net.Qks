﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Net.Qks.Web.Areas.Admin.Models.Layout;
using Net.Qks.Web.Session;
using Net.Qks.Web.Views;

namespace Net.Qks.Web.Areas.Admin.Views.Shared.Components.AdminTheme5Footer
{
    public class AdminTheme5FooterViewComponent : QksViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AdminTheme5FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
