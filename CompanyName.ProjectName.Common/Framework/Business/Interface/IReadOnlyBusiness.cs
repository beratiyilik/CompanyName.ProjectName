using CompanyName.ProjectName.Common.Framework.Entity.Interface;
using CompanyName.ProjectName.Common.Framework.Message.Interface;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Business.Interface
{
    public interface IReadOnlyBusiness<TEntity, TKey> where TEntity : IEntity<TKey> where TKey : struct
    {
        IResponse<TEntity, TKey> Count(IRequest<TEntity, TKey> request);
        IResponse<TEntity, TKey> GetByPrimaryKey(IRequest<TEntity, TKey> request);
        IResponse<TEntity, TKey> List(IRequest<TEntity, TKey> request);
        Task<IResponse<TEntity, TKey>> CountAsync(IRequest<TEntity, TKey> request);
        Task<IResponse<TEntity, TKey>> GetByPrimaryKeyAsync(IRequest<TEntity, TKey> request);
        Task<IResponse<TEntity, TKey>> ListAsync(IRequest<TEntity, TKey> request);
    }
}
