using AmarisTest.Domain.Interfaces;
using AmarisTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarisTest.Dal
{
    public class EmployeeRepostory : IEmployeeRepository
    {
        private readonly List<Employee> _employees;
        public EmployeeRepostory()
        {
            List<Employee> employees = new List<Employee>() {
                new Employee()
                {
                    Id= 1,
                    LastName = "Jones",
                    Name = "Vanity",
                    EmployeeSalary = 12000
                },
                new Employee() {                    
                    Id= 4,
                    LastName = "Payne",
                    Name = "Max",
                    EmployeeSalary =17200},
                new Employee() {                    
                    Id= 5,
                    LastName = "Irons",
                    Name = "Jeremy",
                    EmployeeSalary = 22000
                },
                new Employee() {
                    Id= 53,
                    LastName = "Eastwood",
                    Name = "Clint",
                    EmployeeSalary = 18000
                },
                new Employee() {
                    Id= 52,
                    LastName = "McFly",
                    Name = "George",
                    EmployeeSalary = 12700
                },
                new Employee() {
                    Id= 34,
                    LastName = "Andersson",
                    Name = "Thomas",
                    EmployeeSalary = 14000
                }
            };
            _employees = employees.ToList();

        }
        public async Task<Employee[]> GetEmployee()
        {
            return await Task.FromResult(_employees.ToArray());
        }

        public async Task<Employee?> GetEmployee(int id)
        {
            return await Task.FromResult(_employees.FirstOrDefault(e => e.Id == id));
        }
    }
}
