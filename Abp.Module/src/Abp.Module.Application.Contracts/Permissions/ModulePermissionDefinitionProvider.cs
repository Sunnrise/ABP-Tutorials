using Abp.Module.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Module.Permissions;

public class ModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ModulePermissions.GroupName, L("Permission:Module"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ModuleResource>(name);
    }
}
