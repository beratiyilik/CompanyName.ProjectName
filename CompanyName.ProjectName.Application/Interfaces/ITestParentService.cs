using CompanyName.ProjectName.Application.Models;
using CompanyName.ProjectName.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Application.Interfaces
{
    public interface ITestParentService
    {
        Task<IEnumerable<TestParentModel>> GetTestParentList();
    }
}
