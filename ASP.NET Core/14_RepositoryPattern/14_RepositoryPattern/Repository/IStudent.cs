using _14_RepositoryPattern.Models;

namespace _14_RepositoryPattern.Repository
{
    public interface IStudent
    {
        List<Student> getAllStudents();
        Student getStudentById(int id);
    }
}
