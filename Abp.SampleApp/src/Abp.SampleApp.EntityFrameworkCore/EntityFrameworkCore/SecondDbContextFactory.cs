namespace Abp.SampleApp.EntityFrameworkCore;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SecondDbContextFactory : IDesignTimeDbContextFactory<SecondDbContext>
{
    public SecondDbContext CreateDbContext(string[] args)
    {
        SampleAppEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SecondDbContext>()
            .UseMySql(configuration.GetConnectionString("AbpAuditLogging"), ServerVersion.AutoDetect(configuration.GetConnectionString("AbpAuditLogging")));

        return new SecondDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Abp.SampleApp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
