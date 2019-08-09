//using Abp.Dependency;
//using Castle.MicroKernel.Registration;
//using Castle.Windsor.MsDependencyInjection;
//using Microsoft.Data.Sqlite;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using Net.Qks.EntityFrameworkCore;
//using Net.Qks.Identity;

//namespace Net.Qks.Tests
//{
//    public static class ServiceCollectionRegistrar
//    {
//        public static void Register(IIocManager iocManager)
//        {
//            RegisterIdentity(iocManager);

//            var builder = new DbContextOptionsBuilder<QksDbContext>();

//            var inMemorySqlite = new SqliteConnection("Data Source=:memory:");
//            builder.UseSqlite(inMemorySqlite);

//            iocManager.IocContainer.Register(
//                Component
//                    .For<DbContextOptions<QksDbContext>>()
//                    .Instance(builder.Options)
//                    .LifestyleSingleton()
//            );

//            inMemorySqlite.Open();

//            new QksDbContext(builder.Options).Database.EnsureCreated();
//        }

//        private static void RegisterIdentity(IIocManager iocManager)
//        {
//            var services = new ServiceCollection();

//            IdentityRegistrar.Register(services);

//            WindsorRegistrationHelper.CreateServiceProvider(iocManager.IocContainer, services);
//        }
//    }
//}
