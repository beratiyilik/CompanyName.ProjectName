using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Message
{
    public class RequestInfo
    {
        public BaseRequest Request { get; set; }

        public RequestInfo(BaseRequest request)
        {
            this.Request = request;
        }
    }
}
