using CompanyName.ProjectName.Common.Framework.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Repository.Interface
{
    public interface IReadOnlyRepository<TEntity, TKey> where TEntity : IEntity<TKey> where TKey : struct
    {
        int Count();
        int Count(Expression<Func<TEntity, bool>> filter = null);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> filter = null);
        TEntity GetFirst(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null);
        Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null);
        TEntity GetOne(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null);
        Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null);
        TEntity GetByPrimaryKey(TKey key);
        Task<TEntity> GetByPrimaryKeyAsync(TKey key);
        bool IsExist(TKey key);
        bool IsExist(Expression<Func<TEntity, bool>> filter = null);
        Task<bool> IsExistsAsync(TKey key);
        Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> filter = null);
        IEnumerable<TEntity> List();
        IEnumerable<TEntity> List(Expression<Func<TEntity, bool>> filter = null);
        IEnumerable<TEntity> List(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null);
        IEnumerable<TEntity> List(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null);
        Task<IEnumerable<TEntity>> ListAsync();
        Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<IEnumerable<TEntity>> ListAsync(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null);
        Task<IEnumerable<TEntity>> LİstAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null);
    }
}