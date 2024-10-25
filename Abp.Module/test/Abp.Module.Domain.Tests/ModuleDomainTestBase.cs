﻿using Volo.Abp.Modularity;

namespace Abp.Module;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class ModuleDomainTestBase<TStartupModule> : ModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
