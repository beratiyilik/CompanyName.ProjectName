﻿using CompanyName.ProjectName.Common.Entities.Base.Interface;
using CompanyName.ProjectName.Common.Framework.Business.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Application.Business.Base.Interface
{
    public interface IApplicationBusiness<TEntity> : IBusiness<TEntity, Guid> where TEntity : IApplicationEntity { }
}
