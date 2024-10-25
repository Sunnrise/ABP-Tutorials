using Abp.SampleApp.Samples;
using Xunit;

namespace Abp.SampleApp.EntityFrameworkCore.Domains;

[Collection(SampleAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SampleAppEntityFrameworkCoreTestModule>
{

}
