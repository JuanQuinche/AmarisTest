using AmarisTest.Services;

namespace AmarisTest.BLL
{
    [TestClass()]
    public class EmployeeBllTests
    {

        [TestMethod()]
        public void CalculateAnnualSalaryTest()
        {
            int salary = 10000;
            var employeeBll = new AmarisTest.BLL.EmployeeBll(new EmployeeService(new HttpClient()));

            var response = employeeBll.CalculateAnnualSalary(salary);

            Assert.AreEqual(response, 120000);
        }
    }
}