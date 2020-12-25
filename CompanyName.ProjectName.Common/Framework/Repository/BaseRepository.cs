using CompanyName.ProjectName.Common.Framework.Entity;
using CompanyName.ProjectName.Common.Framework.Repository.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Repository
{
    public abstract class BaseRepository<TEntity, TKey> : BaseReadOnlyRepository<TEntity, TKey>, IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey> where TKey : struct
    {
        /*
        internal DbContext Context;
        internal DbSet<TEntity> DbSet;

        public BaseRepository(DbContext context): base(context)
        {
            this.Context = context;
            this.DbSet = context.Set<TEntity>();
        }
        */

        public abstract void Delete(TKey key);

        public abstract void Delete(IEnumerable<TKey> keyList);

        public abstract Task DeleteAsync(TKey key);

        public abstract Task DeleteAsync(IEnumerable<TKey> keyList);

        public abstract TEntity Insert(TEntity entity);

        public abstract IEnumerable<TEntity> Insert(IEnumerable<TEntity> entityList);

        public abstract Task<TEntity> InsertAsync(TEntity entity);

        public abstract Task<IEnumerable<TEntity>> InsertAsync(IEnumerable<TEntity> entityList);

        public abstract bool Save();

        public abstract Task<bool> SaveAsync();

        public abstract TEntity Update(TEntity entity);

        public abstract IEnumerable<TEntity> Update(IEnumerable<TEntity> entityList);

        public abstract Task<TEntity> UpdateAsync(TEntity entity);

        public abstract Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entityList);
    }
}