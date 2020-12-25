using CompanyName.ProjectName.Common.Entities;
using CompanyName.ProjectName.Common.Repositories;
using CompanyName.ProjectName.Common.Specifications;
using CompanyName.ProjectName.Infrastructure.Data;
using CompanyName.ProjectName.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Infrastructure.Repository
{
    public class TestChildRepository : Repository<TestChild>, ITestChildRepository
    {
        public TestChildRepository(ProjectNameContext dbContext): base(dbContext)
        {
        }

        public async Task<IEnumerable<TestChild>> GetTestChildListByTestParentAsync(Guid testParentId)
        {
            return await _dbContext.TestChilds
                .Where(x => x.Id == testParentId)
                .ToListAsync();
        }

        public async Task<IEnumerable<TestChild>> GetTestChildListByNameAsync(string name)
        {
            var spec = new TestChildWithTestParentSpecification(name);
            return await GetAsync(spec);
        }

        public async Task<IEnumerable<TestChild>> GetTestChildListAsync()
        {
            var spec = new TestChildWithTestParentSpecification();
            return await GetAsync(spec);
        }
    }
}
