using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Net.Qks
{
    [DependsOn(typeof(QksClientModule), typeof(AbpAutoMapperModule))]
    public class QksXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QksXamarinSharedModule).GetAssembly());
        }
    }
}