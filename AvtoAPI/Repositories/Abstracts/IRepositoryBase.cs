using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Repositories
{
    public interface IRepositoryBase<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetAsync(int id);
        Task<TEntity> Create(TEntity entity);
        Task<TEntity>UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
    }
}
