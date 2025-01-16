using System.ComponentModel.DataAnnotations;

namespace StudentWebApp.Entity
{
    public class Student
    {
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int RollNo { get; set; }

        public string Address { get; set; }
        public string Email { get; set; }
    }
}
