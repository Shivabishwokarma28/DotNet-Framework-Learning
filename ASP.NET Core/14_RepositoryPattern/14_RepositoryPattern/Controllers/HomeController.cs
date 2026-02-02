using System.Diagnostics;
using _14_RepositoryPattern.Models;
using _14_RepositoryPattern.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _14_RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository=null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();//StudentRepository is name of repository 
        }
        public List<Student> getAllStudents()
        {
            return _studentRepository.getAllStudents();
        }
        public Student getById(int id)
        {
            return _studentRepository.getStudentById(id);
        }

        public IActionResult Index()
        {
            //var students = new List<Student>
            //{
            //    new Student{Id=1001, Name="Ram",Address="Kathmandu",Standard=11 },
            //    new Student{Id=1002, Name="Shyam",Address="Kathmandu",Standard=11 },
            //    new Student{Id=1003, Name="Krishna",Address="Vrindabaan",Standard=11 },
            //    new Student{Id=1004, Name="Radha",Address="Vrindabaan",Standard=11 }

            //};
            ////ViewBag.StudentData = students;
            //ViewData["StudentData"] = students;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
