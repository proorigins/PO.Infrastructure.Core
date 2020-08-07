using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PO.Infrastructure.Core.Models;

namespace PO.Infrastructure.Core.Repositories
{
    public abstract class Repository<TDbContext, TDbModel> : IRepository<TDbModel>
        where TDbModel : class, IDbModelBase
        where TDbContext : DbContext
    {
        protected TDbContext Context { set; get; }

        protected Repository(TDbContext context)
        {
            Context = context;
        }

        public async Task<List<TDbModel>> FindAllAsync()
        {
            return await Context.Set<TDbModel>().ToListAsync();
        }

        public async Task<TDbModel> FindByIdAsync(object id)
        {
            return await Context.Set<TDbModel>().FindAsync(id);
        }

        public void Create(TDbModel entity)
        {
            Context.Set<TDbModel>().Add(entity);
        }

        public void CreateMany(List<TDbModel> entity)
        {
            Context.Set<TDbModel>().AddRange(entity);
        }

        public void Update(TDbModel entity)
        {
            Context.Set<TDbModel>().Update(entity);
        }
        
        public void Delete(TDbModel entity)
        {
            Context.Set<TDbModel>().Remove(entity);
        }

        public void DeleteMany(List<TDbModel> entity)
        {
            Context.Set<TDbModel>().RemoveRange(entity);
        }
    }
}