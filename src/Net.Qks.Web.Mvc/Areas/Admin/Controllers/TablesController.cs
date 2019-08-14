using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Net.Qks.Authorization;
using Net.Qks.Web.Controllers;
using Net.Qks.Develop;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Net.Qks.Web.Mvc.Areas.Admin.Controllers
{
    [Area(QksConsts.Admin)]
    [AbpMvcAuthorize(AppPermissions.Develop.Tables)]
    public class TablesController : QksControllerBase
    {
        public readonly ITableAppService _tableService;

        public TablesController(ITableAppService tableAppService)
        {
            _tableService = tableAppService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AbpMvcAuthorize(AppPermissions.Develop.Tables_Create, AppPermissions.Develop.Tables_Edit)]
        public async Task<PartialViewResult> CreateOrEditModal(int? id)
        {
            var output = await _tableService.Get(new NullableIdDto<int> { Id = id });

            return PartialView("CreateOrEditModal", output);
        }
    }
}