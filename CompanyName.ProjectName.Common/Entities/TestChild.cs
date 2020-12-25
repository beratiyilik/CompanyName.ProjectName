using CompanyName.ProjectName.Common.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Entities
{
    public class TestChild : BaseApplicationEntity 
    {
        public string Name { get; set; }

        public Guid ParentId { get; set; }

        public TestParent Parent { get; set; }

        public static TestChild Create(string name)
        {
            var testChild = new TestChild
            {
                Id = Guid.NewGuid(),
                Name = name
            };
            return testChild;
        }
    }
}
