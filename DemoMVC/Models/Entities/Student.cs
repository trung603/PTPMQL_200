using System.ComponentModel.DataAnnotations;

namespace  DemoMVC.Models.Entities {

    public class Student {
        [Key]
        public required String StudentID {get; set;}
        public required String FullName {get; set;}
        public required String Address { get; set; }
    }
}
