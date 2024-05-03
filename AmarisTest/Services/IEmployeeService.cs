using AmarisTest.Models;

namespace AmarisTest.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();

        Task<Employee?> GetEmployee(int id);
    }
}
