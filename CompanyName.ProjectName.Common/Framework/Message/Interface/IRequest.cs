using CompanyName.ProjectName.Common.Framework.Entity.Interface;

namespace CompanyName.ProjectName.Common.Framework.Message.Interface
{
    public interface IRequest : IMessage { }

    public interface IRequest<TEntity, TKey> : IMessage<TEntity, TKey> where TEntity : IEntity<TKey> where TKey : struct { }
}
