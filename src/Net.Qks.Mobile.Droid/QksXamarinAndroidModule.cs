using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Net.Qks
{
    [DependsOn(typeof(QksXamarinSharedModule))]
    public class QksXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QksXamarinAndroidModule).GetAssembly());
        }
    }
}