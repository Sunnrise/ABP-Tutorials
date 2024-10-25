using Volo.Abp.Modularity;

namespace SampleApp;

/* Inherit from this class for your domain layer tests. */
public abstract class SampleAppDomainTestBase<TStartupModule> : SampleAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
