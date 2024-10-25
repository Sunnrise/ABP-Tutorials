using Abp.Module.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Module;

public abstract class ModuleController : AbpControllerBase
{
    protected ModuleController()
    {
        LocalizationResource = typeof(ModuleResource);
    }
}
