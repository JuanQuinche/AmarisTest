using AmarisTest.Models;

namespace AmarisTest.BLL
{
    public interface IEmployeeBll
    {
        Task<IEnumerable<EmployeeViewModel>> GetEmployeesVM();
        int CalculateAnnualSalary(int employeeSalary);
    }
}