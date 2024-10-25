using System.Threading.Tasks;

namespace Abp.SampleApp.Data;

public interface ISampleAppDbSchemaMigrator
{
    Task MigrateAsync();
}
