using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Net.Qks
{
    public class QksClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QksClientModule).GetAssembly());
        }
    }
}
