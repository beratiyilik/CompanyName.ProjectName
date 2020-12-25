using CompanyName.ProjectName.Common.Entities;
using CompanyName.ProjectName.Common.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Repositories
{
    public interface ITestChildRepository : IRepository<TestChild>
    {
        Task<IEnumerable<TestChild>> GetTestChildListAsync();
        Task<IEnumerable<TestChild>> GetTestChildListByNameAsync(string name);
        Task<IEnumerable<TestChild>> GetTestChildListByTestParentAsync(Guid testParentId);
    }
}
