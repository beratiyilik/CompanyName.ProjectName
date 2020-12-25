using CompanyName.ProjectName.Common.Entities.Base.Interface;
using CompanyName.ProjectName.Common.Framework.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Repositories.Base
{
    public interface IApplicationRepository<TEntity>: IRepository<TEntity, Guid> where TEntity : IApplicationEntity { }
}
