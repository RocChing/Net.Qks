using Abp.AspNetCore.Mvc.ViewComponents;

namespace Net.Qks.Web.Public.Views
{
    public abstract class QksViewComponent : AbpViewComponent
    {
        protected QksViewComponent()
        {
            LocalizationSourceName = QksConsts.LocalizationSourceName;
        }
    }
}