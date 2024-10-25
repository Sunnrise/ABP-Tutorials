using Abp.SampleApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.SampleApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SampleAppController : AbpControllerBase
{
    protected SampleAppController()
    {
        LocalizationResource = typeof(SampleAppResource);
    }
}
