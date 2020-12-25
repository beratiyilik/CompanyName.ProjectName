using CompanyName.ProjectName.Common.Entities.Base;
using CompanyName.ProjectName.Common.Framework.Message;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Messages
{
    public class BaseApplicationResponse : BaseResponse { }

    public class BaseApplicationResponse<TEntity> : BaseResponse<TEntity, Guid> where TEntity : BaseApplicationEntity { }
}
