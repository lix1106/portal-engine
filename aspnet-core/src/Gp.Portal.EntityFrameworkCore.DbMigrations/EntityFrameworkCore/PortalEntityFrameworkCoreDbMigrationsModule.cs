using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Gp.Portal.EntityFrameworkCore
{
    [DependsOn(
        typeof(PortalEntityFrameworkCoreModule)
        )]
    public class PortalEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PortalMigrationsDbContext>();
        }
    }
}
