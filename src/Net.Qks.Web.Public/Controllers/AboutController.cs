﻿using Microsoft.AspNetCore.Mvc;
using Net.Qks.Web.Controllers;

namespace Net.Qks.Web.Public.Controllers
{
    public class AboutController : QksControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}