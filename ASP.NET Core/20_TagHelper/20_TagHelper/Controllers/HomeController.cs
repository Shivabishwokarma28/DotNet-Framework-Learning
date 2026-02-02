using System.Diagnostics;
using _20_TagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace _20_TagHelper.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Contact()
        {
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
