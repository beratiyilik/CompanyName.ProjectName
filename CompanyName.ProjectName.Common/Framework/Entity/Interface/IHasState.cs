using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CompanyName.ProjectName.Common.Framework.Enum.Enum;

namespace CompanyName.ProjectName.Common.Framework.Entity.Interface
{
    public interface IHasState
    {
        EntityState State { get; set; }
    }
}
