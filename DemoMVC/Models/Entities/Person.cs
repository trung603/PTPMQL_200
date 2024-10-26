using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace DemoMVC.Models.Entities
{
    public class Person
    {
        [Key]
        public string PersonID { get; set;}
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}