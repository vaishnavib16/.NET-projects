using Microsoft.EntityFrameworkCore.Query;
using StudentWebApp.Entity;
using StudentWebApp.Repository;

namespace StudentWebApp.Service
{
    public class StudentIml : StudentInterface
    {
        private readonly StudentContext _context=new StudentContext();
        public Student Delete(int Id)
        {
            using (var context = new  StudentContext())
            {
                var Students = context.Students.Find(Id);
                context.Students.Remove(Students);
                context.SaveChanges();
                return Students;
            }
        }

        public List<Student> GetAll()
        {
            var stud = _context.Students.ToList();
            return stud;
        }

        public Student Insert(Student student)
        {
            using (var context = new StudentContext())
            {
             var std=context.Students.Add(student);
             context.SaveChanges();
                return student;
            }
                
            
        }

        public Student Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return student;
        }
    }
}
