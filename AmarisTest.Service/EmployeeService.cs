using AmarisTest.Domain.Interfaces;
using AmarisTest.Domain.Models;

namespace AmarisTest.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeService(IEmployeeRepository repo) {
            _repo = repo;
        }

        public List<Employee> GetEmployee()
        {
            var processed = new List<Employee>();
            var employees = _repo.GetEmployee();
            foreach( var e in employees)
            {
                e.EmployeeAnnualSalary = e.EmployeeAnnualSalary*12;
                processed.Add(e);
            }
            return processed;
        }

        Employee IEmployeeService.GetEmployee(int id)
        {
            var employee = _repo.GetEmployee(id);
            employee.EmployeeAnnualSalary = employee.EmployeeSalary * 12;
            return employee;
        }
    }
}
