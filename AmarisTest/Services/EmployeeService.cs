using AmarisTest.Helpers;
using AmarisTest.Models;

namespace AmarisTest.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public const string baseUrl ="/api/v1/employees";

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));


        }

        public async Task<Employee?> GetEmployee(int id)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/{id}");
            return await response.ReadContentAsync<Employee?>();
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var httpResponse = await _httpClient.GetAsync(baseUrl);
            var response = await httpResponse.ReadContentAsync<Root>();
            return response.data;

        }
    }
}
