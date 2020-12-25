using CompanyName.ProjectName.Common.Framework.Business.Interface;
using CompanyName.ProjectName.Common.Framework.Entity;
using CompanyName.ProjectName.Common.Framework.Message.Interface;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Business
{
    public abstract class BaseBusiness<TEntity, TKey> : BaseReadOnlyBusiness<TEntity, TKey>, IBusiness<TEntity, TKey> where TEntity : BaseEntity<TKey> where TKey : struct
    {
        // protected RepositoryBase<TEntity> _repository = null;
        public IResponse<TEntity, TKey> Delete(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResponse<TEntity, TKey>> DeleteAsync(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }

        public IResponse<TEntity, TKey> Insert(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResponse<TEntity, TKey>> InsertAsync(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }

        public IResponse<TEntity, TKey> Update(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResponse<TEntity, TKey>> UpdateAsync(IRequest<TEntity, TKey> request)
        {
            throw new System.NotImplementedException();
        }
    }
}
