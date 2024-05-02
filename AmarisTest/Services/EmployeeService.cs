using AmarisTest.Domain.Models;

namespace AmarisTest.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeHttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<Employee?> GetEmployee(int id)
        {
            return await _httpClient.GetEmployee(id);
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _httpClient.GetEmployee();
        }
    }
}
