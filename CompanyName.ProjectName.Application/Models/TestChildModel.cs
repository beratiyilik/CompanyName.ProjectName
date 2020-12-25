using CompanyName.ProjectName.Application.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Application.Models
{
    public class TestChildModel : BaseModel
    {
        public string Name { get; set; }
        public Guid? TestParentId { get; set; }
        public TestParentModel TestParent { get; set; }
    }
}
