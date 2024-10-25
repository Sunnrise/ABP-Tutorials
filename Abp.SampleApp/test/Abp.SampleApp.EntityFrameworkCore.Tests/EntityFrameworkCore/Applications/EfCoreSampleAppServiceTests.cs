using Abp.SampleApp.Samples;
using Xunit;

namespace Abp.SampleApp.EntityFrameworkCore.Applications;

[Collection(SampleAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SampleAppEntityFrameworkCoreTestModule>
{

}
