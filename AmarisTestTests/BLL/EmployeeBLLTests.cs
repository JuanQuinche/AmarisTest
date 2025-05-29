using AmarisTest.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmarisTestTests.BLL
{
    [TestClass]
    public class EmployeeBLLTests
    {
        private readonly IEmployeeBll _employeeBll;

        public EmployeeBLLTests(IEmployeeBll employeeBLL)
        {
            _employeeBll = employeeBLL;
        }

        [TestMethod]
        public void GetEmployeesVMTest()
        {
            //Arrange

            //Action


            //Assert
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateAnnualSalaryTest()
        {
            var salary = 10000;
            int expectedResult = 120000;
            int result = _employeeBll.CalculateAnnualSalary(salary);
            Assert.AreEqual(result, expectedResult);
        }
    }
}