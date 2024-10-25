using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Abp.Module.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(ModuleBlazorModule)
    )]
public class ModuleBlazorServerModule : AbpModule
{

}
