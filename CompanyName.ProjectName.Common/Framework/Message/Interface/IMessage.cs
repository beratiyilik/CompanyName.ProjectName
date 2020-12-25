using CompanyName.ProjectName.Common.Framework.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Message.Interface
{
    public interface IMessage { }

    public interface IMessage<TEntity, TKey> : IMessage where TEntity : IEntity<TKey> where TKey : struct
    {
        TKey Key { get; set; }

        IEnumerable<TKey> KeyList { get; set; }

        TEntity Entity { get; set; }

        IEnumerable<TEntity> EntityList { get; set; }
    }
}