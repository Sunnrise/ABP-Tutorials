using Volo.Abp.Guids;
using Volo.Abp.Modularity;

namespace Abp.Module.Customers;

public class Customer_Tests : ModuleDomainTestBase<AbpModule>
{
    private IGuidGenerator _guidGenerator;

    public Customer_Tests()
    {
        _guidGenerator = GetRequiredService<IGuidGenerator>();
    }
    
    
}