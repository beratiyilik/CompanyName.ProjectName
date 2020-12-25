using CompanyName.ProjectName.Common.Entities;
using CompanyName.ProjectName.Common.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Specifications
{
    public sealed class TestChildWithTestParentSpecification : BaseSpecification<TestChild>
    {
        public TestChildWithTestParentSpecification(string name)
            : base(p => p.Name.ToLower().Contains(name.ToLower()))
        {
            AddInclude(p => p.Parent);
        }

        public TestChildWithTestParentSpecification() : base(null)
        {
            AddInclude(p => p.Parent);
        }
    }
}
