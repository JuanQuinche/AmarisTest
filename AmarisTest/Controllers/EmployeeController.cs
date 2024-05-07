using AmarisTest.BLL;
using AmarisTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AmarisTest.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeBLL _employeeBLL;

        public EmployeeController(ILogger<HomeController> logger, IEmployeeBLL service)
        {
            _logger = logger;
            _employeeBLL = service;
        }

        public IActionResult Index()
        {
            var info = _employeeBLL.GetEmployeesVM().Result.ToList();


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
