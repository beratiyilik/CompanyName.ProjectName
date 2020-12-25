using CompanyName.ProjectName.Application.Business.Base.Interface;
using CompanyName.ProjectName.Common.Entities.Base;
using CompanyName.ProjectName.Common.Framework.Business;
using System;

namespace CompanyName.ProjectName.Application.Business
{
    public abstract class BaseApplicationReadOnlyBusiness<TEntity> : BaseReadOnlyBusiness<TEntity, Guid>, IApplicationReadOnlyBusiness<TEntity> where TEntity : BaseApplicationEntity { }
}
