using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Framework.Enum
{
    public class Enum
    {
        [Flags]
        // [BindableTypeAttribute(IsBindable = false)]
        [Bindable(BindableSupport.No)]
        [Description("Entity State")]
        public enum EntityState
        {
            [Description("Active")]
            Active = 1,
            [Description("Passive")]
            Passive = 2,
            [Description("Deleted")]
            Deleted = 3
        }

        [Description("Operation Result")]
        public enum OperationResult
        {
            [Display(Description = "Initial Value", Name = "None")]
            [Description("None")]
            Null = 0,
            [Display(Description = "The operation completed successfully", Name = "OK")]
            [Description("OK")]
            OK = 1,
            [Display(Description = "The Operation Failed!", Name = "Error")]
            [Description("Error")]
            Err = 2,
            [Display(Description = "The operation completed successfully, but no data returned!", Name = "No Data")]
            [Description("No Data")]
            NoData = 3
        }
    }
}
