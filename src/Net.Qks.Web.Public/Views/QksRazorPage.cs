using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Net.Qks.Web.Public.Views
{
    public abstract class QksRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected QksRazorPage()
        {
            LocalizationSourceName = QksConsts.LocalizationSourceName;
        }
    }
}
