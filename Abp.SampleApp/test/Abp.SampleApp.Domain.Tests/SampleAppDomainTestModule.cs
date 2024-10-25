using Volo.Abp.Modularity;

namespace Abp.SampleApp;

[DependsOn(
    typeof(SampleAppDomainModule),
    typeof(SampleAppTestBaseModule)
)]
public class SampleAppDomainTestModule : AbpModule
{

}
