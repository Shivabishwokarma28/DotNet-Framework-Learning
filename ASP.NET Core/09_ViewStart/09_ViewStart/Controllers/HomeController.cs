using Microsoft.AspNetCore.Mvc;

namespace _09_ViewStart.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("Home/Contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
