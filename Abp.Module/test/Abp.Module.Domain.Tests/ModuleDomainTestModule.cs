using Volo.Abp.Modularity;

namespace Abp.Module;

[DependsOn(
    typeof(ModuleDomainModule),
    typeof(ModuleTestBaseModule)
)]
public class ModuleDomainTestModule : AbpModule
{

}
