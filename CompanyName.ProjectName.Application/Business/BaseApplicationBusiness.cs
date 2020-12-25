using CompanyName.ProjectName.Application.Business.Base.Interface;
using CompanyName.ProjectName.Common.Entities.Base;
using CompanyName.ProjectName.Common.Framework.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Application.Business.Interface
{
    public abstract class BaseApplicationBusiness<TEntity> : BaseBusiness<TEntity, Guid>, IApplicationBusiness<TEntity> where TEntity : BaseApplicationEntity { }
}
