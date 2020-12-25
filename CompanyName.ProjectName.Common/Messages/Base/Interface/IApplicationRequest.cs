using CompanyName.ProjectName.Common.Entities.Base.Interface;
using CompanyName.ProjectName.Common.Framework.Message.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Messages.Base.Interface
{
    public interface IApplicationRequest : IRequest { }

    public interface IApplicationRequest<TEntity> : IRequest<TEntity, Guid> where TEntity : IApplicationEntity { }
}
