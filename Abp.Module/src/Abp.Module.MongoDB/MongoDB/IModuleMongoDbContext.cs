using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.Module.MongoDB;

[ConnectionStringName(ModuleDbProperties.ConnectionStringName)]
public interface IModuleMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
