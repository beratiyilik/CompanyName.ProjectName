using AutoMapper;
using CompanyName.ProjectName.Application.Interfaces;
using CompanyName.ProjectName.Application.Mapper;
using CompanyName.ProjectName.Application.Models;
using CompanyName.ProjectName.Common.Entities;
using CompanyName.ProjectName.Common.Interfaces;
using CompanyName.ProjectName.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Application.Services
{
    public class TestParentService : ITestParentService
    {
        private readonly ITestParentRepository _testParentRepository;
        private readonly IAppLogger<TestParentService> _logger;


        public TestParentService(ITestParentRepository testParentRepository, IAppLogger<TestParentService> logger)
        {
            _testParentRepository = testParentRepository ?? throw new ArgumentNullException(nameof(testParentRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        public async Task<IEnumerable<TestParentModel>> GetTestParentList()
        {
            var model = await _testParentRepository.GetAllAsync();
            var mapped = ObjectMapper.Mapper.Map<IEnumerable<TestParentModel>>(model);
            return mapped;
        }
    }
}
