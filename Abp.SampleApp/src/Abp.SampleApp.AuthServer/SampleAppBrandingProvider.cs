using Microsoft.Extensions.Localization;
using Abp.SampleApp.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.SampleApp;

[Dependency(ReplaceServices = true)]
public class SampleAppBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<SampleAppResource> _localizer;

    public SampleAppBrandingProvider(IStringLocalizer<SampleAppResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
