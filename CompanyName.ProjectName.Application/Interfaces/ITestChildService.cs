using CompanyName.ProjectName.Application.Models;
using CompanyName.ProjectName.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Application.Interfaces
{
    public interface ITestChildService
    {
        Task<IEnumerable<TestChildModel>> GetTestChildList();
        Task<TestChildModel> GetTestChildById(Guid id);
        Task<IEnumerable<TestChildModel>> GetTestChildListByName(string name);
        Task<IEnumerable<TestChildModel>> GetTestChildListByTestParent(Guid id);
        Task<TestChildModel> Create(TestChildModel testChild);
        Task Update(TestChildModel testChild);
        Task Delete(TestChildModel testChild);
    }
}
