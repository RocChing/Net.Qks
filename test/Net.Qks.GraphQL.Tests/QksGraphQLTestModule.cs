using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Net.Qks.Configure;
using Net.Qks.Startup;
using Net.Qks.Test.Base;

namespace Net.Qks.GraphQL.Tests
{
    [DependsOn(
        typeof(QksGraphQLModule),
        typeof(QksTestBaseModule))]
    public class QksGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QksGraphQLTestModule).GetAssembly());
        }
    }
}