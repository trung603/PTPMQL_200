using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.Entities
{
    public class Employee
    {
        [Key]
        public required string EmployeeID { get; set; }
        public required String FullName { get; set; }
        public required String Address { get; set; }
    }
}