using Abp.Module.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Abp.Module.Blazor.Server.Host;

public abstract class ModuleComponentBase : AbpComponentBase
{
    protected ModuleComponentBase()
    {
        LocalizationResource = typeof(ModuleResource);
    }
}
