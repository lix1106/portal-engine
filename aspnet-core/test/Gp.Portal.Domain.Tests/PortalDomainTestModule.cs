using Gp.Portal.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Gp.Portal
{
    [DependsOn(
        typeof(PortalEntityFrameworkCoreTestModule)
        )]
    public class PortalDomainTestModule : AbpModule
    {

    }
}