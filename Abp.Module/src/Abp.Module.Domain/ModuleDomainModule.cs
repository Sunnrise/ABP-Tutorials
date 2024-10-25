using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Abp.Module;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ModuleDomainSharedModule)
)]
public class ModuleDomainModule : AbpModule
{

}
