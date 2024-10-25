using Abp.Module.Samples;
using Xunit;

namespace Abp.Module.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<ModuleMongoDbTestModule>
{

}
