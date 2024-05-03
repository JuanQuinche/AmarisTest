namespace AmarisTest.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Employee_name { get; set; }
        public int Employee_salary { get; set; }
        public int Employee_age { get; set; }
        public string Profile_image { get; set; }
    }

    public class Root
    {
        public string status { get; set; }
        public List<Employee> data { get; set; }
        public string message { get; set; }
    }
}
