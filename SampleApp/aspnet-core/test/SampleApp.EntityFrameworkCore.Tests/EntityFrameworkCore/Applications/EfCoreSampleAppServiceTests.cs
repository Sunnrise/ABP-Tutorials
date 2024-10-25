using SampleApp.Samples;
using Xunit;

namespace SampleApp.EntityFrameworkCore.Applications;

[Collection(SampleAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SampleAppEntityFrameworkCoreTestModule>
{

}
