using Microsoft.AspNetCore.Mvc;

namespace _06_LoginProject.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}