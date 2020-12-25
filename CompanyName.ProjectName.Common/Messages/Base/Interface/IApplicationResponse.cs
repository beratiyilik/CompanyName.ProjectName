using CompanyName.ProjectName.Common.Entities.Base.Interface;
using CompanyName.ProjectName.Common.Framework.Message.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Messages.Base.Interface
{
    public interface IApplicationResponse : IResponse { }

    public interface IApplicationResponse<TEntity> : IResponse<TEntity, Guid> where TEntity : IApplicationEntity { }
}
