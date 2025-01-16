using StudentWebApp.Entity;

namespace StudentWebApp.Service
{
    public interface StudentInterface
    {
        Student Insert(Student student);

        Student Update(Student student);
        
        Student Delete(int Id);

        List<Student> GetAll();
    }
}
