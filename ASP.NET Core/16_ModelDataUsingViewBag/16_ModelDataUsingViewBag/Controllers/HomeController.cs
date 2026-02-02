using System.Diagnostics;
using _16_ModelDataUsingViewBag.Models;
using Microsoft.AspNetCore.Mvc;

namespace _16_ModelDataUsingViewBag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var emp = new List<Employee>
            {
                
                new Employee{EmpID = 1001,EmpName="Ram",Designation="Manager",Salary=50000},
                new Employee{EmpID = 1002,EmpName="Shiva",Designation="CEo",Salary=1000000000}
            };
            ViewData["DataEmp"] = emp;
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
