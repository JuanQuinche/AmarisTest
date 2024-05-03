using AmarisTest.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AmarisTest.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            service = service ?? throw new ArgumentNullException(nameof(service));

        }

        public async Task<IActionResult> EmployeeIndex()
        {
            var employees = await _service.GetEmployee();
            return View(employees);  
        }

    }
}
