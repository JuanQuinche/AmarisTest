namespace AmarisTest.Models
{
    public class EmployeeViewModel : Employee
    {
        public int EmployeeAnnualSalary { get; set; }
        public EmployeeViewModel()
        {
            EmployeeAnnualSalary = Employee_salary * 12;
        }
    }
}
