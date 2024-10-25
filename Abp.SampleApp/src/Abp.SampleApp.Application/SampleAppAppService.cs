using System;
using System.Collections.Generic;
using System.Text;
using Abp.SampleApp.Localization;
using Volo.Abp.Application.Services;

namespace Abp.SampleApp;

/* Inherit your application services from this class.
 */
public abstract class SampleAppAppService : ApplicationService
{
    protected SampleAppAppService()
    {
        LocalizationResource = typeof(SampleAppResource);
    }
}
