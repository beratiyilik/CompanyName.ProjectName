using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Repository
{
    /*
    public class EntityFrameworkRepository<TEntity, TKey> : RepositoryBase<TEntity, TKey> where TEntity : BaseEntity<TKey> where TKey : struct
    {
        internal DbContext Context;
        internal DbSet<TEntity> DbSet;

        public EntityFrameworkRepository(DbContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<TEntity>();
        }
        public override int Count()
        {
            throw new NotImplementedException();
        }

        public override int Count(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public override Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<int> CountAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public override TEntity GetFirst(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public override Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public override TEntity GetOne(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public override Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public override TEntity GetByPrimaryKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public override Task<TEntity> GetByPrimaryKeyAsync(TKey key)
        {
            throw new NotImplementedException();
        }

        public override bool IsExist(TKey key)
        {
            throw new NotImplementedException();
        }

        public override bool IsExist(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> IsExistsAsync(TKey key)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TEntity> List()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TEntity> List(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TEntity> List(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TEntity> List(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<TEntity>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<TEntity>> ListAsync(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<TEntity>> LİstAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null, int? skip = null, int? take = null)
        {
            throw new NotImplementedException();
        }

        public override void Delete(TKey key)
        {
            throw new NotImplementedException();
        }

        public override void Delete(IEnumerable<TKey> keyList)
        {
            throw new NotImplementedException();
        }

        public override Task DeleteAsync(TKey key)
        {
            throw new NotImplementedException();
        }

        public override Task DeleteAsync(IEnumerable<TKey> keyList)
        {
            throw new NotImplementedException();
        }

        public override TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TEntity> Insert(IEnumerable<TEntity> entityList)
        {
            throw new NotImplementedException();
        }

        public override Task<TEntity> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<TEntity>> InsertAsync(IEnumerable<TEntity> entityList)
        {
            throw new NotImplementedException();
        }

        public override bool Save()
        {
            throw new NotImplementedException();
        }

        public override Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public override TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TEntity> Update(IEnumerable<TEntity> entityList)
        {
            throw new NotImplementedException();
        }

        public override Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entityList)
        {
            throw new NotImplementedException();
        }
    }
    */
}