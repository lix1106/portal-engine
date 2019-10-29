using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Gp.Portal.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(PortalHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class PortalConsoleApiClientModule : AbpModule
    {
        
    }
}
