using Volo.Abp.Modularity;

namespace SampleApp;

public abstract class SampleAppApplicationTestBase<TStartupModule> : SampleAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
