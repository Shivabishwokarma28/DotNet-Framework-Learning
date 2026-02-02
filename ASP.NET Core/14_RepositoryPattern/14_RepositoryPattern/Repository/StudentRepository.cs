using _14_RepositoryPattern.Models;

namespace _14_RepositoryPattern.Repository
{
    public class StudentRepository : IStudent
    {
        public List<Student> getAllStudents()
        {
            return DataSource();
            
        }

        public Student getStudentById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        private List<Student> DataSource()
        {
            return new List<Student> {new Student{Id=1001, Name="Ram",Address="Kathmandu",Standard=11 },
                new Student{Id=1002, Name="Shyam",Address="Kathmandu",Standard=11 },
                new Student{Id=1003, Name="Krishna",Address="Vrindabaan",Standard=11 },
                new Student{Id=1004, Name="Radha",Address="Vrindabaan",Standard=11 } 
            };
        }
    }
}
