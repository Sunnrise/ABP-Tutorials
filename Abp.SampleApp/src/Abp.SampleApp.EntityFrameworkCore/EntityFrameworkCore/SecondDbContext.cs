using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.SampleApp.EntityFrameworkCore;

[ConnectionStringName("AbpAuditLogging")]
public class SecondDbContext : AbpDbContext<SecondDbContext>
{
    public SecondDbContext(DbContextOptions<SecondDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ConfigureAuditLogging();
        base.OnModelCreating(builder);
    }
}

