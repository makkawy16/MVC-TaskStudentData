using Microsoft.AspNetCore.Mvc;
using TaskStudentData.Models;

namespace TaskStudentData.Controllers
{

    public class StudentController : Controller
    {
        StudentSample studentSample = new StudentSample();

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Test()
        {
            return "Hello";
        }

        public IActionResult GetAllStudents() {
            var students = studentSample.GetStudents();
            return View("StudentList",students);
        }
        
      public  IActionResult GetStudent(int id) {

            var student = studentSample.GetStudent(id);
            return View("StudentDeatils", student);

        }
    }
}
