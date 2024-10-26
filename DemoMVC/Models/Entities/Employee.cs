namespace DemoMVC.Models.Entities
{
    public class Employee : Person
    {
        public required string EmployeeID { get; set; }
        public required string Company { get; set; }
    }
}