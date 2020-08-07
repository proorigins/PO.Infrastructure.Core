using System.Collections.Generic;
using System.Threading.Tasks;
using PO.Infrastructure.Core.Models;

namespace PO.Infrastructure.Core.Repositories
{
    public interface IRepository<TDbModel> : IRepositoryBase 
        where TDbModel : IDbModelBase
    {
        Task<List<TDbModel>> FindAllAsync();
        Task<TDbModel> FindByIdAsync(object id);
        void Create(TDbModel entity);
        void CreateMany(List<TDbModel> entity);
        void Update(TDbModel entity);
        void Delete(TDbModel entity);
        void DeleteMany(List<TDbModel> entity);
    }
}