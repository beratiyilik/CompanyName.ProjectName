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
    public class TestChildService : ITestChildService
    {
        private readonly ITestChildRepository _testChildRepository;
        private readonly IAppLogger<TestChildService> _logger;

        public TestChildService(ITestChildRepository testChildRepository, IAppLogger<TestChildService> logger)
        {
            _testChildRepository = testChildRepository ?? throw new ArgumentNullException(nameof(testChildRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<TestChildModel> Create(TestChildModel testChild)
        {
            await ValidateTestChildIfExist(testChild);

            var mappedEntity = ObjectMapper.Mapper.Map<TestChild>(testChild);
            if (mappedEntity == null)
                throw new ApplicationException($"Entity could not be mapped.");

            var newEntity = await _testChildRepository.AddAsync(mappedEntity);
            _logger.LogInformation($"Entity successfully added - TestChildService");

            var newMappedEntity = ObjectMapper.Mapper.Map<TestChildModel>(newEntity);
            return newMappedEntity;
        }

        public async Task Delete(TestChildModel testChild)
        {
            ValidateTestChildIfNotExist(testChild);
            var deleteModel = await _testChildRepository.GetByIdAsync(testChild.Id);
            if (deleteModel == null)
                throw new ApplicationException($"Entity could not be loaded.");

            await _testChildRepository.DeleteAsync(deleteModel);
            _logger.LogInformation($"Entity successfully deleted - TestChildService");
        }

        public async Task<IEnumerable<TestChildModel>> GetTestChildListByTestParent(Guid id)
        {
            var productList = await _testChildRepository.GetTestChildListByTestParentAsync(id);
            var mapped = ObjectMapper.Mapper.Map<IEnumerable<TestChildModel>>(productList);
            return mapped;
        }

        public async Task<TestChildModel> GetTestChildById(Guid id)
        {
            var model = await _testChildRepository.GetByIdAsync(id);
            var mapped = ObjectMapper.Mapper.Map<TestChildModel>(model);
            return mapped;
        }

        public async Task<IEnumerable<TestChildModel>> GetTestChildListByName(string name)
        {
            var list = await _testChildRepository.GetTestChildListByNameAsync(name);
            var mapped = ObjectMapper.Mapper.Map<IEnumerable<TestChildModel>>(list);
            return mapped;
        }

        public async Task<IEnumerable<TestChildModel>> GetTestChildList()
        {
            var list = await _testChildRepository.GetTestChildListAsync();
            var mapped = ObjectMapper.Mapper.Map<IEnumerable<TestChildModel>>(list);
            return mapped;
        }

        public async Task Update(TestChildModel testChild)
        {
            ValidateTestChildIfNotExist(testChild);

            var editModel = await _testChildRepository.GetByIdAsync(testChild.Id);
            if (editModel == null)
                throw new ApplicationException($"Entity could not be loaded.");

            ObjectMapper.Mapper.Map<TestChildModel, TestChild>(testChild, editModel);

            await _testChildRepository.UpdateAsync(editModel);
            _logger.LogInformation($"Entity successfully updated - TestChildService");
        }

        private async Task ValidateTestChildIfExist(TestChildModel model)
        {
            var existingEntity = await _testChildRepository.GetByIdAsync(model.Id);
            if (existingEntity != null)
                throw new ApplicationException($"{model.ToString()} with this id already exists");
        }

        private void ValidateTestChildIfNotExist(TestChildModel model)
        {
            var existingEntity = _testChildRepository.GetByIdAsync(model.Id);
            if (existingEntity == null)
                throw new ApplicationException($"{model.ToString()} with this id is not exists");
        }
    }
}
