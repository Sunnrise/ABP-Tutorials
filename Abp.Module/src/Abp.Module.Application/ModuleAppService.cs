using Abp.Module.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Module;

public abstract class ModuleAppService : ApplicationService
{
    protected ModuleAppService()
    {
        LocalizationResource = typeof(ModuleResource);
        ObjectMapperContext = typeof(ModuleApplicationModule);
    }
}
