using CompanyName.ProjectName.Common.Framework.Entity.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Repository.Interface
{
    public interface IRepository<TEntity, TKey> : IReadOnlyRepository<TEntity, TKey> where TEntity : IEntity<TKey> where TKey : struct
    {
        void Delete(TKey key);
        void Delete(IEnumerable<TKey> keyList);
        Task DeleteAsync(TKey key);
        Task DeleteAsync(IEnumerable<TKey> keyList);
        TEntity Insert(TEntity entity);
        IEnumerable<TEntity> Insert(IEnumerable<TEntity> entityList);
        Task<TEntity> InsertAsync(TEntity entity);
        Task<IEnumerable<TEntity>> InsertAsync(IEnumerable<TEntity> entityList);
        bool Save();
        Task<bool> SaveAsync();
        TEntity Update(TEntity entity);
        IEnumerable<TEntity> Update(IEnumerable<TEntity> entityList);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entityList);
    }
}