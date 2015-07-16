using System.Threading;
using System.Threading.Tasks;

namespace Voat.Persistence
{
    public interface IReadWriteDbContext : IVoatDbContext
    {
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
