using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gp.Portal.Data;
using Volo.Abp.DependencyInjection;

namespace Gp.Portal.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCorePortalDbSchemaMigrator 
        : IPortalDbSchemaMigrator, ITransientDependency
    {
        private readonly PortalMigrationsDbContext _dbContext;

        public EntityFrameworkCorePortalDbSchemaMigrator(PortalMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}