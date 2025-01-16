using StudentApplication.Models;
using StudentApplication.Repository;

namespace StudentApplication.Services
{
    public class StudentImpl : StudentInterface
    {
        private readonly StudentColectionContext _context = new StudentColectionContext();

        public Student Delete(int id)
        {
            using (var context = new StudentColectionContext())
            {
                var Students = context.Students.Find(id);
                context.Students.Remove(Students);
                context.SaveChanges();
                return Students;
            }
        }

        public List<Student> GetAll()
        {
            var students = _context.Students.ToList();
            return students;
        }

        public Student Insert(Student student)
        {
            using var context = new StudentColectionContext();
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
            return student;
        }

        public Student Update(Student student)
        {
            using (var context = new StudentColectionContext())
            {
                context.Students.Update(student);
                context.SaveChanges();
            }
            return student;
        }
        public List<Student> Sort()
        {
            using ( var context = new StudentColectionContext())
            {
                var Student=context.Students.OrderBy(s=>s.status=="active"?0:1).ToList();
                return Student.ToList<Student>();
            }

        }
    }
     
}
