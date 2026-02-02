using System.Diagnostics;
using _13_ModelsInASPCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13_ModelsInASPCore.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        public IActionResult Index()
        {
            var students = new List<StudentModel>
            {
                new StudentModel{Roll_No=1, Name="Ram",Address="Kathmandu",Standard=11 },
                new StudentModel{Roll_No=2, Name="Shyam",Address="Kathmandu",Standard=11 },
                new StudentModel{Roll_No=3, Name="Krishna",Address="Vrindabaan",Standard=11 },
                new StudentModel{Roll_No=4, Name="Radha",Address="Vrindabaan",Standard=11 }

            };
            //ViewBag.StudentData = students;
            ViewData["StudentData"]=students;
            return View();
        }
        [Route("Home/Employe")]
        public IActionResult Employe()
        {
            var Emp = new List<Employee>
            {
            new Employee{Emp_Id=1, Emp_Name="Siddhartha",Emp_Address="Tamghas"},
            new Employee{Emp_Id=2, Emp_Name="Robin",Emp_Address="Butwal"},
            new Employee{Emp_Id=3, Emp_Name="Praveen",Emp_Address="Tamghas"},
            };
            ViewBag.EmployeData=Emp;
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
