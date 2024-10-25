using Abp.Module.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.Module.Pages;

public abstract class ModulePageModel : AbpPageModel
{
    protected ModulePageModel()
    {
        LocalizationResourceType = typeof(ModuleResource);
    }
}
