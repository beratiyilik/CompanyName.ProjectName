using CompanyName.ProjectName.Common.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.ProjectName.Common.Entities
{
    public class TestParent : BaseApplicationEntity 
    {
        public TestParent()
        {
             Childs = new HashSet<TestChild>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<TestChild> Childs { get; private set; }

        public static TestParent Create(string name, string description = null)
        {
            var category = new TestParent
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description
            };
            return category;
        }
    }
}
