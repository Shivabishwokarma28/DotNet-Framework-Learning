using System.Diagnostics;
using _30_Session.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace _30_Session.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //creating session
            HttpContext.Session.SetString("Session","ShivaData");
            return View();
        }

        public IActionResult Privacy()
        {
            
            return View();
        }
        public IActionResult About()
        {
            //Accessing session
             if (HttpContext.Session.GetString("Session") != null)
            {
                ViewBag.Data = HttpContext.Session.GetString("Session").ToString();
                TempData["SessionID"] = HttpContext.Session.Id;
            }
            return View();
        }
        public IActionResult Logout()
        {
            if(HttpContext.Session.GetString("Session")!=null)
            {
                HttpContext.Session.Remove("Session");
            }

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
