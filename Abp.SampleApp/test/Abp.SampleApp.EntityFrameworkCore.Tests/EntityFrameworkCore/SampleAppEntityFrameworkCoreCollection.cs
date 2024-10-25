using Xunit;

namespace Abp.SampleApp.EntityFrameworkCore;

[CollectionDefinition(SampleAppTestConsts.CollectionDefinitionName)]
public class SampleAppEntityFrameworkCoreCollection : ICollectionFixture<SampleAppEntityFrameworkCoreFixture>
{

}
