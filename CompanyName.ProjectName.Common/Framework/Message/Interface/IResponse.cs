using CompanyName.ProjectName.Common.Framework.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Framework.Message.Interface
{
    public interface IResponse : IMessage { }

    public interface IResponse<TEntity, TKey> : IMessage<TEntity, TKey> where TEntity : IEntity<TKey> where TKey : struct { }
}
