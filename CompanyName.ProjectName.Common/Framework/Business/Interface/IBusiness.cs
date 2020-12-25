using CompanyName.ProjectName.Common.Framework.Entity.Interface;
using CompanyName.ProjectName.Common.Framework.Message.Interface;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Business.Interface
{
    public interface IBusiness<TEntity, TKey> : IReadOnlyBusiness<TEntity, TKey> where TEntity : IEntity<TKey> where TKey : struct
    {
        IResponse<TEntity, TKey> Delete(IRequest<TEntity, TKey> request);
        IResponse<TEntity, TKey> Insert(IRequest<TEntity, TKey> request);
        IResponse<TEntity, TKey> Update(IRequest<TEntity, TKey> request);
        Task<IResponse<TEntity, TKey>> DeleteAsync(IRequest<TEntity, TKey> request);
        Task<IResponse<TEntity, TKey>> InsertAsync(IRequest<TEntity, TKey> request);
        Task<IResponse<TEntity, TKey>> UpdateAsync(IRequest<TEntity, TKey> request);
    }
}
