using Volo.Abp.Modularity;

namespace Gp.Portal
{
    [DependsOn(
        typeof(PortalApplicationModule),
        typeof(PortalDomainTestModule)
        )]
    public class PortalApplicationTestModule : AbpModule
    {

    }
}