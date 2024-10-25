using Volo.Abp.Ui.Branding;

namespace Abp.Module.Blazor.Host.Client;

public class ModuleHostBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Module";
}
