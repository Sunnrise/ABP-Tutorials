using Abp.SampleApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.SampleApp.Web.Pages;

public abstract class SampleAppPageModel : AbpPageModel
{
    protected SampleAppPageModel()
    {
        LocalizationResourceType = typeof(SampleAppResource);
    }
}
