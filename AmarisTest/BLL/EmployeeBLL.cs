﻿using AmarisTest.Models;
using AmarisTest.Services;

namespace AmarisTest.BLL
{
    public class EmployeeBll : IEmployeeBll
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeBll(IEmployeeService employeeService) => _employeeService = employeeService;

        public async Task<IEnumerable<EmployeeViewModel>> GetEmployeesVM()
        {
            var data = await _employeeService.GetEmployees();

            return data.
                Select(x => new EmployeeViewModel
                    {
                        Id = x.Id,
                        Employee_name = x.Employee_name,
                        Employee_age = x.Employee_age,
                        Employee_salary = x.Employee_salary,
                        EmployeeAnnualSalary = CalculateAnnualSalary(x.Employee_salary)
                    });
        }

        public int CalculateAnnualSalary(int employeeSalary)
        {
            return employeeSalary * 12;
        }
    }
}
