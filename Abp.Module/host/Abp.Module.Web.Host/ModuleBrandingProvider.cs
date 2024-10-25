﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.Module;

[Dependency(ReplaceServices = true)]
public class ModuleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Module";
}
