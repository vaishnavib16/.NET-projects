using Microsoft.AspNetCore.Mvc;

using StudentApplication.Services;
using StudentApplication.Models;
namespace StudentWebApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentInterface studentImpl;

        public StudentController(StudentInterface studentService)
        {
            this.studentImpl = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Student student)
        {
            studentImpl.Insert(student);
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            studentImpl.Delete(id);
            return RedirectToAction("GetStudents"); 
        }


        public IActionResult GetStudents()
        {

            return View(studentImpl.GetAll());
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            studentImpl.Update(student);
            return View();
        }
        public IActionResult Sort() { 
            return View(studentImpl.Sort());
        }

    }
}

