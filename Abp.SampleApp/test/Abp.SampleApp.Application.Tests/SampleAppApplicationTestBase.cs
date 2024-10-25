using Volo.Abp.Modularity;

namespace Abp.SampleApp;

public abstract class SampleAppApplicationTestBase<TStartupModule> : SampleAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
