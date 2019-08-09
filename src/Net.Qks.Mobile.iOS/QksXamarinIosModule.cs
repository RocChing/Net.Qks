using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Net.Qks
{
    [DependsOn(typeof(QksXamarinSharedModule))]
    public class QksXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QksXamarinIosModule).GetAssembly());
        }
    }
}