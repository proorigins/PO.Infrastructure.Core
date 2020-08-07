using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PO.Infrastructure.Core.UnitOfWork
{
    public class UnitOfWorkBase<TDbContext> : IUnitOfWorkBase
        where TDbContext : DbContext
    {
        private readonly TDbContext _contextBase;
        
        public UnitOfWorkBase(TDbContext contextBase)
        {
            _contextBase = contextBase;
        }
        
        public void Dispose()
        {
        }

        public async Task SaveAsync()
        {
            await _contextBase.SaveChangesAsync();
        }
    }
}