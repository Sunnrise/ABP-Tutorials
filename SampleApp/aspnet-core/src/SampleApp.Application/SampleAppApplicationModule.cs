using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Blogging;
using Volo.Blogging.Admin;
using SampleModule;

namespace SampleApp;

[DependsOn(
    typeof(SampleAppDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(SampleAppApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
[DependsOn(typeof(BloggingApplicationModule))]
    [DependsOn(typeof(BloggingAdminApplicationModule))]
    [DependsOn(typeof(SampleModuleApplicationModule))]
    public class SampleAppApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<SampleAppApplicationModule>();
        });
    }
}
