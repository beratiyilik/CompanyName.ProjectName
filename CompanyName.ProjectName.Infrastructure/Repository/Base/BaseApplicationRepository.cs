using CompanyName.ProjectName.Common.Entities.Base;
using CompanyName.ProjectName.Common.Framework.Repository;
using CompanyName.ProjectName.Common.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;

namespace CompanyName.ProjectName.Infrastructure.Repository.Base
{
    public abstract class BaseApplicationRepository<TEntity> : BaseRepository<TEntity, Guid>, IApplicationRepository<TEntity> where TEntity : BaseApplicationEntity
    {
        // public BaseApplicationRepository(DbContext context) : base(context) { }
    }
}
