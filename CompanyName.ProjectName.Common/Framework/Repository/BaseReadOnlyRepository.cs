using CompanyName.ProjectName.Common.Framework.Entity;
using CompanyName.ProjectName.Common.Framework.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Repository
{
    public abstract class BaseReadOnlyRepository<TEntity, TKey> : IReadOnlyRepository<TEntity, TKey> where TEntity : BaseEntity<TKey> where TKey : struct
    {
        /*
        internal DbContext Context;
        internal DbSet<TEntity> DbSet;

        public BaseReadOnlyRepository(DbContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<TEntity>();
        }
        */

        public abstract int Count();

        public abstract int Count(Expression<Func<TEntity, bool>> filter = null);

        public abstract Task<int> CountAsync();

        public abstract Task<int> CountAsync(Expression<Func<TEntity, bool>> filter = null);

        public abstract TEntity GetFirst(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null);

        public abstract Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null);

        public abstract TEntity GetOne(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null);

        public abstract Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null);

        public abstract TEntity GetByPrimaryKey(TKey key); //  => this.DbSet.Find(key);

        public abstract Task<TEntity> GetByPrimaryKeyAsync(TKey key); //  => await this.DbSet.FindAsync(key);

        public abstract bool IsExist(TKey key);

        public abstract bool IsExist(Expression<Func<TEntity, bool>> filter = null);

        public abstract Task<bool> IsExistsAsync(TKey key);

        public abstract Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> filter = null);

        public abstract IEnumerable<TEntity> List();

        public abstract IEnumerable<TEntity> List(Expression<Func<TEntity, bool>> filter = null);

        public abstract IEnumerable<TEntity> List(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null);

        public abstract IEnumerable<TEntity> List(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null);

        public abstract Task<IEnumerable<TEntity>> ListAsync();

        public abstract Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>> filter = null);

        public abstract Task<IEnumerable<TEntity>> ListAsync(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null);

        public abstract Task<IEnumerable<TEntity>> LİstAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null);
    }
}