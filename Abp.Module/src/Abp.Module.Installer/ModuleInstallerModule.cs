using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Abp.Module;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class ModuleInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ModuleInstallerModule>();
        });
    }
}
