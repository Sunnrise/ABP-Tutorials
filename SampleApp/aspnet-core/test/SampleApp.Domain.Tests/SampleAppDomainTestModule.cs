using Volo.Abp.Modularity;

namespace SampleApp;

[DependsOn(
    typeof(SampleAppDomainModule),
    typeof(SampleAppTestBaseModule)
)]
public class SampleAppDomainTestModule : AbpModule
{

}
