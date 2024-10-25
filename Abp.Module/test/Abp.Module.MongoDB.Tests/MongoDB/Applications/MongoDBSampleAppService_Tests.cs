using Abp.Module.MongoDB;
using Abp.Module.Samples;
using Xunit;

namespace Abp.Module.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<ModuleMongoDbTestModule>
{

}
