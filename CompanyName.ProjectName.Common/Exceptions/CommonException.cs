using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Exceptions
{
    public class CommonException : Exception
    {
        internal CommonException(string businessMessage)
            : base(businessMessage)
        {
        }

        internal CommonException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
