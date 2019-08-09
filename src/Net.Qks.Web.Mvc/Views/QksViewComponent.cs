using Abp.AspNetCore.Mvc.ViewComponents;

namespace Net.Qks.Web.Views
{
    public abstract class QksViewComponent : AbpViewComponent
    {
        protected QksViewComponent()
        {
            LocalizationSourceName = QksConsts.LocalizationSourceName;
        }
    }
}