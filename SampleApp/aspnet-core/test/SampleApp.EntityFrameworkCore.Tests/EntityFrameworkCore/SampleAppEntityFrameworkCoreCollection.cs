using Xunit;

namespace SampleApp.EntityFrameworkCore;

[CollectionDefinition(SampleAppTestConsts.CollectionDefinitionName)]
public class SampleAppEntityFrameworkCoreCollection : ICollectionFixture<SampleAppEntityFrameworkCoreFixture>
{

}
