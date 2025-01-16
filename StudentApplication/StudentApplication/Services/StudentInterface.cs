using StudentApplication.Models;

namespace StudentApplication.Services
{
    public interface StudentInterface
    {
        Student Insert(Student student);

        List<Student> GetAll();

        Student Delete(int id);
        Student Update(Student student);

        List<Student> Sort();
    }
}
