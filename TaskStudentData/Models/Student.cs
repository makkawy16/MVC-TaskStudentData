using System.ComponentModel.DataAnnotations;

namespace TaskStudentData.Models
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Img { get; set; } 
        public string Address { get; set; }

    }
}
