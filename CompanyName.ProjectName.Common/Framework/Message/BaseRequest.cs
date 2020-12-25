using CompanyName.ProjectName.Common.Framework.Entity;
using CompanyName.ProjectName.Common.Framework.Message.Interface;
using System.Collections.Generic;

namespace CompanyName.ProjectName.Common.Framework.Message
{
    public abstract class BaseRequest : IRequest
    {
        public MessageHeader Header { get; set; }

        public BaseRequest()
        {
            this.Header = new MessageHeader();
        }
    }
    public abstract class BaseRequest<TEntity, TKey> : BaseRequest, IRequest<TEntity, TKey> where TEntity : BaseEntity<TKey> where TKey : struct
    {
        public TKey Key { get; set; }

        public IEnumerable<TKey> KeyList { get; set; }

        public TEntity Entity { get; set; }

        public IEnumerable<TEntity> EntityList { get; set; }

        // public PagingHelper PagingHelper { get; set; }

        public BaseRequest()
        {

        }

        public BaseRequest(TEntity entityInstance)
        {
            this.Entity = entityInstance;
        }
    }
}
