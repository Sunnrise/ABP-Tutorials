using Abp.Module.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.Module.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ModulePageModel : AbpPageModel
{
    protected ModulePageModel()
    {
        LocalizationResourceType = typeof(ModuleResource);
        ObjectMapperContext = typeof(ModuleWebModule);
    }
}
