using AmarisTest.Domain.Interfaces;
using AmarisTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarisTest.Dal
{
    public class EmployeeRepostory : IEmployeeRepository
    {
        public Employee[] GetEmployee()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
