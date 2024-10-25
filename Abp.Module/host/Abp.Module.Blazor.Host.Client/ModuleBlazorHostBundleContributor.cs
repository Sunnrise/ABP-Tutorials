using Volo.Abp.Bundling;

namespace Abp.Module.Blazor.Host.Client;

public class ModuleBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
