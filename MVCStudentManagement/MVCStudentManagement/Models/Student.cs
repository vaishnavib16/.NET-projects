
using System.ComponentModel.DataAnnotations;




namespace MVCStudentManagement.Models
{
    
    public class Student
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public Status Status { get; set; }

    }
}
