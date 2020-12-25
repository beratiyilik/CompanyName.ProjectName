using CompanyName.ProjectName.Common.Framework.Entity;
using CompanyName.ProjectName.Common.Framework.Message.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Message
{
    public abstract class BaseResponse : IResponse
    {
        public RequestInfo RequestInfo { get; set; }

        /*
        public ValidationResultCollection ValidationResults { get; set; }
         */

        public BaseResponse()
        {
            /*
            this.ValidationResults = new ValidationResultCollection();
             */
        }

        public BaseResponse(BaseRequest request)
        {
            this.RequestInfo = new RequestInfo(request);
        }
    }
    public abstract class BaseResponse<TEntity, TKey> : BaseResponse, IResponse<TEntity, TKey> where TEntity : BaseEntity<TKey> where TKey : struct
    {
        public TKey Key { get; set; }

        public IEnumerable<TKey> KeyList { get; set; }

        public TEntity Entity { get; set; }

        public IEnumerable<TEntity> EntityList { get; set; }

        // public PagingHelper PagingHelper { get; set; }

        public int Count { get; set; }
    }
}
