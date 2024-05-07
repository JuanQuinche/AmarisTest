using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmarisTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarisTest.BLL.Tests
{
    [TestClass()]
    public class EmployeeBLLTests
    {
        private readonly IEmployeeBLL _employeeBLL;

        public EmployeeBLLTests(IEmployeeBLL employeeBLL)
        {
            _employeeBLL = employeeBLL;
        }

        [TestMethod()]
        public void GetEmployeesVMTest()
        {
            //Arrange

            //Action


            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void CalculateAnnualSalaryTest()
        {
            var salary = 10000;
            int expected_result = 120000;
            int result = _employeeBLL.CalculateAnnualSalary(salary);
            Assert.AreEqual(result, expected_result);
        }
    }
}