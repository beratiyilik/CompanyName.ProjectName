using CompanyName.ProjectName.Common.Entities;
using CompanyName.ProjectName.Common.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Specifications
{
    public sealed class TestParentWithTestChildsSpecification : BaseSpecification<TestParent>
    {
        public TestParentWithTestChildsSpecification(Guid Id)
            : base(b => b.Id == Id)
        {
            AddInclude(b => b.Childs);
        }
    }
}
