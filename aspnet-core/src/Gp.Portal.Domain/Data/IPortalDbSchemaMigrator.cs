using System.Threading.Tasks;

namespace Gp.Portal.Data
{
    public interface IPortalDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
