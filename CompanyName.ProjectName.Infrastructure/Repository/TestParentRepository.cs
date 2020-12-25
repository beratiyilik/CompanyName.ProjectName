using CompanyName.ProjectName.Common.Entities;
using CompanyName.ProjectName.Common.Repositories;
using CompanyName.ProjectName.Common.Specifications;
using CompanyName.ProjectName.Infrastructure.Data;
using CompanyName.ProjectName.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Infrastructure.Repository
{
    public class TestParentRepository : Repository<TestParent>, ITestParentRepository
    {
        public TestParentRepository(ProjectNameContext dbContext): base(dbContext)
        {
        }

        public async Task<TestParent> GetTestParentWithTestChildsAsync(Guid Id)
        {
            var spec = new TestParentWithTestChildsSpecification(Id);
            var testParent = (await GetAsync(spec)).FirstOrDefault();
            return testParent;
        }
    }
}
