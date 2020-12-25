using CompanyName.ProjectName.Common.Entities.Base;
using CompanyName.ProjectName.Common.Framework.Message;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Messages
{
    public class BaseApplicaitonRequest : BaseRequest { }

    public class BaseApplicaitonRequest<TEntity> : BaseRequest<TEntity, Guid> where TEntity : BaseApplicationEntity { }
}
