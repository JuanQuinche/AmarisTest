using AmarisTest.Domain.Models;

namespace AmarisTest.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();

        Task<Employee?> GetEmployee(int id);
    }
}
