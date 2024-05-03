using AmarisTest.Models;
using AmarisTest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AmarisTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService _service;

        public HomeController(ILogger<HomeController> logger, IEmployeeService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            var info = _service.GetEmployees().Result.Select(e => new EmployeeViewModel {
                Employee_name= e.Employee_name,
                Id= e.Id,
                Employee_salary=e.Employee_salary,
                Employee_age=e.Employee_age,
                EmployeeAnnualSalary = e.Employee_salary *12
            }           
            ).ToList();

            
            if (info == null)
            {
                return View();
            }
            else
            {
                return View(info);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}