using Abp.AspNetZeroCore;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Net.Qks.Configuration;
using Net.Qks.EntityFrameworkCore;
using Net.Qks.Identity;
using Net.Qks.MultiTenancy;
using Net.Qks.Web.Areas.Admin.Startup;

namespace Net.Qks.Web.Startup
{
    [DependsOn(
        typeof(QksWebCoreModule)
    )]
    public class QksWebMvcModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        private readonly IHtmlHelper _helper;
        public QksWebMvcModule(
            IHostingEnvironment env, IHtmlHelper htmlHelper)
        {
            _appConfiguration = env.GetAppConfiguration();
            _helper = htmlHelper;
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpWebCommon().MultiTenancy.DomainFormat = _appConfiguration["App:WebSiteRootAddress"] ?? "http://localhost:62114/";
            Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];
            Configuration.Navigation.Providers.Add<AdminNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QksWebMvcModule).GetAssembly());

            Logger.Info(_helper.GetType().FullName);
        }

        public override void PostInitialize()
        {
            if (!IocManager.Resolve<IMultiTenancyConfig>().IsEnabled)
            {
                return;
            }

            using (var scope = IocManager.CreateScope())
            {
                if (!scope.Resolve<DatabaseCheckHelper>().Exist(_appConfiguration["ConnectionStrings:Default"]))
                {
                    return;
                }
            }

            var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
            workManager.Add(IocManager.Resolve<SubscriptionExpirationCheckWorker>());
            workManager.Add(IocManager.Resolve<SubscriptionExpireEmailNotifierWorker>());
        }
    }
}