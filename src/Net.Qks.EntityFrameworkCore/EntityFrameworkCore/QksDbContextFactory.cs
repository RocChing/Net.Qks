using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Net.Qks.Configuration;
using Net.Qks.Web;

namespace Net.Qks.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class QksDbContextFactory : IDesignTimeDbContextFactory<QksDbContext>
    {
        public QksDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<QksDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            QksDbContextConfigurer.Configure(builder, configuration.GetConnectionString(QksConsts.ConnectionStringName));

            return new QksDbContext(builder.Options);
        }
    }
}