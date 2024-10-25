using SampleApp.Samples;
using Xunit;

namespace SampleApp.EntityFrameworkCore.Domains;

[Collection(SampleAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SampleAppEntityFrameworkCoreTestModule>
{

}
