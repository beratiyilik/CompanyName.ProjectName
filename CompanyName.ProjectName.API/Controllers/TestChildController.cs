using AutoMapper;
using CompanyName.ProjectName.Application.Interfaces;
using CompanyName.ProjectName.Application.Models;
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
    public class TestChildController : ControllerBase
    {
        private readonly ITestChildService _testChildService;
        private readonly IMapper _mapper;
        private readonly ILogger<TestChildController> _logger;

        public TestChildController(ITestChildService testChildService, IMapper mapper, ILogger<TestChildController> logger)
        {
            _testChildService = testChildService ?? throw new ArgumentNullException(nameof(testChildService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        [SwaggerResponse(200, type: typeof(TestChildModel), description: "Get TestChild records.")]
        [SwaggerResponse(500, "An error occurred while processing your request")]
        public async Task<IActionResult> GetTestChild()
        {
            try
            {
                var list = await _testChildService.GetTestChildList();

                return Ok(list.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

}
