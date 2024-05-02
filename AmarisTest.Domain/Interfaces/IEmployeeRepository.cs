using AmarisTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarisTest.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee[] GetEmployee();
        Employee GetEmployee(int id);
    }
}
