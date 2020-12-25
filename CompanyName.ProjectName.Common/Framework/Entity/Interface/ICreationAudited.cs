using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Entity.Interface
{
    public interface ICreationAudited<TKey> : IHasCreationTime where TKey : struct
    {
        TKey CreatedById { get; set; }
    }
}
