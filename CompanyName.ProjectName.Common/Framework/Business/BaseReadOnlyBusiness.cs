using CompanyName.ProjectName.Common.Framework.Business.Interface;
using CompanyName.ProjectName.Common.Framework.Entity;
using CompanyName.ProjectName.Common.Framework.Message.Interface;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Business
{
    public abstract class BaseReadOnlyBusiness<TEntity, TKey> : IReadOnlyBusiness<TEntity, TKey> where TEntity : BaseEntity<TKey> where TKey : struct
    {
        // protected ReadOnlyRepositoryBase<TEntity> _readOnlyRepository = null;
        public IResponse<TEntity, TKey> Count(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResponse<TEntity, TKey>> CountAsync(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }

        public IResponse<TEntity, TKey> GetByPrimaryKey(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResponse<TEntity, TKey>> GetByPrimaryKeyAsync(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }

        public IResponse<TEntity, TKey> List(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResponse<TEntity, TKey>> ListAsync(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }
    }
}
