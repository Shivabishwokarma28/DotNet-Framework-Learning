using System.Diagnostics;
using _17_StronglyTypedView.Models;
using Microsoft.AspNetCore.Mvc;

namespace _17_StronglyTypedView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user = new List<UserData>
            { new UserData{UserId=1001,UserName="Rengoku",Email="rengoku@gmail.com"},
            new UserData{UserId=1002,UserName="Prakash",Email="prakvskrm@gmail.com"}
            };
            //UserData user = new UserData()
            //{ UserId = 1001, UserName = "Rengoku", Email = "rengoku@gmail.com" };
            return View(user);
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
