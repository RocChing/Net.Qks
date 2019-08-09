using Abp.AspNetCore.Mvc.Views;

namespace Net.Qks.Web.Views
{
    public abstract class QksRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected QksRazorPage()
        {
            LocalizationSourceName = QksConsts.LocalizationSourceName;
        }
    }
}
