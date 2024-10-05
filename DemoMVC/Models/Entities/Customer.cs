using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.Entities
{
    public class Customer
    {
        [Key]
        public required string CustomerID{ get; set; }
        [MinLength(3)]
        [Required(ErrorMessage = "Không được để trống!")]
        public required string FullName { get; set; }
        public string? Address { get; set; } 
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }   

    }
}