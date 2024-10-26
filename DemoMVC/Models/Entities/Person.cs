using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace DemoMVC.Models.Entities
{
    public class Person
    {
        [Key]
        public required string PersonID { get; set;}
        public required string FullName { get; set; }
        public required string Address { get; set; }
    }
}