﻿using Gp.Portal.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Gp.Portal.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PortalEntityFrameworkCoreDbMigrationsModule),
        typeof(PortalApplicationContractsModule)
        )]
    public class PortalDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
