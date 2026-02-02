using Microsoft.AspNetCore.Mvc;
using _25_LoginWebProjectScratch.Model;

namespace _25_LoginWebProjectScratch.Controllers
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
        [Route("")]
        public string Index(User us)
        {
            return "UserName :  "+us.Name + "Password :  "+us.Password ;
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

    }
}
