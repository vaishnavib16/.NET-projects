using Microsoft.AspNetCore.Mvc;
using MVCStudentManagement.Data;
using MVCStudentManagement.Models;

namespace MVCStudentManagement.Controllers
{
    public class StudentController : Controller
    { private AppDbContext _db;
        public StudentController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {   
            List<Student> student=_db.students.ToList();
            return View(student);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.students.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Index","Student");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id== null)return NotFound();

            Student? student = _db.students.Find(id);
            if(student ==null )return NotFound();
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.students.Update(student);
                _db.SaveChanges();
                return RedirectToAction("Index", "Student");
            }
            return View();

        }

        public IActionResult Delete(int? id)
        {
            if (id== null || id==0)return NotFound();
            Student? student = _db.students.Find(id);
            if(student == null )return NotFound();
            return View(student);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Student? student = _db.students.Find(id);
            if(student == null)return NotFound();

            
                _db.students.Remove(student);
                _db.SaveChanges();
                return RedirectToAction("Index", "Student");
           

        }




    }
}
