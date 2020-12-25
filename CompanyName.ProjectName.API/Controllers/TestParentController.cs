using AutoMapper;
using CompanyName.ProjectName.Application.Interfaces;
using CompanyName.ProjectName.Application.Models;
using CompanyName.ProjectName.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestParentController : ControllerBase
    {
        private readonly ITestParentService _testParentService;
        private readonly IMapper _mapper;
        private readonly ILogger<TestParentController> _logger;

        public TestParentController(ITestParentService testParentService, IMapper mapper, ILogger<TestParentController> logger)
        {
            _testParentService = testParentService ?? throw new ArgumentNullException(nameof(testParentService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        [SwaggerResponse(200, type: typeof(TestParentModel), description: "Get TestParent records.")]
        [SwaggerResponse(500, "An error occurred while processing your request")]
        public async Task<IActionResult> GetTestParent()
        {
            try
            {
                var list = await _testParentService.GetTestParentList();

                return Ok(list.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
