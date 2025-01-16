using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Prng.Drbg;
using StudentWebApp.Entity;
using StudentWebApp.Service;

namespace StudentWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController:ControllerBase
    {
        private readonly StudentInterface stud;

        public StudentController(StudentInterface stud)
        {
            this.stud = stud;
        }
        [HttpPost]
        public IActionResult Inset(Student student)
        {
            stud.Insert(student);
            return Ok();
        }

        [HttpGet]
        public IActionResult Display()
        {
            
            return Ok(stud.GetAll());
        }

        [HttpPut]
        public IActionResult Update(Student student) 
        { 
            stud.Update(student);
            return Ok();
        }

        [HttpPost("{Id}")]
        public IActionResult Delete(int Id)
        {
            stud.Delete(Id);
            return Ok();
        }

    }
}
