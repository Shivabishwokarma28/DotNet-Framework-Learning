using System.Diagnostics;
using _15_ToDoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _15_ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var tasklist = new List<ToDoApp>()
            {
                new ToDoApp{Id=1001, Task="Learning C#",IsCompleted=true},
                new ToDoApp{Id=1002, Task="Learning ADO.NET",IsCompleted=true},
                new ToDoApp{Id=1003, Task="Learning ASP.NET",IsCompleted=false}
            };
            ViewBag.task=tasklist;
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
