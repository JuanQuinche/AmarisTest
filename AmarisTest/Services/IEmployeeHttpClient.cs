using AmarisTest.Domain.Models;

namespace AmarisTest.Services
{
    public interface IEmployeeHttpClient : HttpClient
    {
        Task<HttpResponseMessage> SendAsync();
        Task<List<EmployeeHttpClient>> GetAsync();

        Task<Employee> EmployeeGetByIdAsync(int id);    
    }
}
