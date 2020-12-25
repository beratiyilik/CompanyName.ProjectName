using CompanyName.ProjectName.Common.Entities;
using CompanyName.ProjectName.Common.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Common.Repositories
{
    public interface ITestParentRepository : IRepository<TestParent>
    {
        Task<TestParent> GetTestParentWithTestChildsAsync(Guid Id);
    }
}
