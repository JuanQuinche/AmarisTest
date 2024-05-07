using AmarisTest.Models;

namespace AmarisTest.BLL
{
    public interface IEmployeeBLL
    {
        Task<IEnumerable<EmployeeViewModel>> GetEmployeesVM();
        int CalculateAnnualSalary(int employee_salary);
    }
}