using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Net.Qks.Authorization;

namespace Net.Qks
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(QksCoreModule)
        )]
    public class QksApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QksApplicationModule).GetAssembly());
        }
    }
}