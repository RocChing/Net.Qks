using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Net.Qks.Startup
{
    [DependsOn(typeof(QksCoreModule))]
    public class QksGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QksGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}