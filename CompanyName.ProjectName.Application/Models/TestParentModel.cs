using CompanyName.ProjectName.Application.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Application.Models
{
    public class TestParentModel : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
