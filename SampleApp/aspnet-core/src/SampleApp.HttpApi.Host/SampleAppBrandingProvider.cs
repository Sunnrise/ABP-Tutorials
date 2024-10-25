using Microsoft.Extensions.Localization;
using SampleApp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SampleApp;

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
