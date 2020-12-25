using CompanyName.ProjectName.Common.Entities.Base;
using CompanyName.ProjectName.Common.Framework.Repository;
using CompanyName.ProjectName.Common.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;

namespace CompanyName.ProjectName.Infrastructure.Repository.Base
{
    public abstract class BaseApplicationReadOnlyRepository<TEntity> : BaseReadOnlyRepository<TEntity, Guid>, IApplicationReadOnlyRepository<TEntity> where TEntity : BaseApplicationEntity
    {
        // public BaseApplicationReadOnlyRepository(DbContext context) : base(context) { }
    }
}
