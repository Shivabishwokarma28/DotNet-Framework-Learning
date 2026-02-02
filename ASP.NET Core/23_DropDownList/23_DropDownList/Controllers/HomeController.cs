using System.Diagnostics;
using _23_DropDownList.Models;
using Microsoft.AspNetCore.Mvc;

namespace _23_DropDownList.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Index(Employee emp)
        {
            return "Name: "+ emp.Name+ "Age: " + emp.Age+ "Designation: " + emp.Designation+ "Salary: " + emp.Salary+ "Gender: " + emp.Gender+ "Description: " + emp.Description;
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
