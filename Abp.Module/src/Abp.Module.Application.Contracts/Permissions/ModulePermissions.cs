using Volo.Abp.Reflection;

namespace Abp.Module.Permissions;

public class ModulePermissions
{
    public const string GroupName = "Module";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ModulePermissions));
    }
}
