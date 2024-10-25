using Volo.Abp.Modularity;

namespace Abp.Module;

[DependsOn(
    typeof(ModuleApplicationModule),
    typeof(ModuleDomainTestModule)
    )]
public class ModuleApplicationTestModule : AbpModule
{

}
