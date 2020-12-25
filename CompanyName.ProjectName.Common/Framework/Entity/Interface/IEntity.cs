using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Framework.Entity.Interface
{
    public interface IEntity<TKey> : IAudited<TKey>, IHasState, IHasTimestamp where TKey : struct
    {
        TKey Id { get; /* set; */ }
    }
}
