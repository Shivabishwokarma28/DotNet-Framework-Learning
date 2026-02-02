using System.Diagnostics;
using _26_ValidationAttributes.Models;
using Microsoft.AspNetCore.Mvc;

namespace _26_ValidationAttributes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student std)
        {
            return View();
            //if(ModelState.IsValid)
            //{
            //    return $"Name is:{std.Name}";
            //}
            //else
            //{
            //    return $"Validation error";
            //}
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
