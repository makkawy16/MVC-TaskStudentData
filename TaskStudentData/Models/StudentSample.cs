namespace TaskStudentData.Models
{
    public class StudentSample
    {
        List<Student> students;

        public StudentSample()
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1 , Name = "makkawy" , Address = "Nasr City" , Img = "book1.jpg" });
            students.Add(new Student() { Id = 2 , Name = "yousef" , Address = "Nasr City" , Img = "book2.jpg" });
            students.Add(new Student() { Id = 3 , Name = "ahmed" , Address = "Nasr City" , Img = "book3.jpg" });
        }

        public List<Student> GetStudents() { 
        return students;
        }

        public Student GetStudent(int id) {
            return students.FirstOrDefault(x => x.Id == id);
        }
    }
}
