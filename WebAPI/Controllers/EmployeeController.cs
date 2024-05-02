using AmarisTest.Domain.Interfaces;
using AmarisTest.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _service;


        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _service.GetEmployee(); 
        }

        [HttpGet("Id")]   
        public Employee GetEmployee(int id)
        { 
            return _service.GetEmployee(id);
        }
    }
}