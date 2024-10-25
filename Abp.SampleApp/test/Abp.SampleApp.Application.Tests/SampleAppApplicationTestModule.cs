using Volo.Abp.Modularity;

namespace Abp.SampleApp;

[DependsOn(
    typeof(SampleAppApplicationModule),
    typeof(SampleAppDomainTestModule)
)]
public class SampleAppApplicationTestModule : AbpModule
{

}
