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

        public async Task<List<Employee>> GetEmployee()
        {
            var processed = new List<Employee>();
            var employees = await _repo.GetEmployee();
            foreach( var e in employees)
            {
                e.EmployeeAnnualSalary = e.EmployeeSalary*12;
                processed.Add(e);
            }
            return processed;
        }

        public async Task<Employee?> GetEmployee(int id)
        {
            var employee = await _repo.GetEmployee(id);
            if (employee != null)
            {
                employee.EmployeeAnnualSalary = employee.EmployeeSalary * 12;
            }

            return employee;
        }
    }
}
