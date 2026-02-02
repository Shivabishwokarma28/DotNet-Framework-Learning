using Microsoft.AspNetCore.Mvc;

namespace _08_LayoutViewProject.Controllers
{
    public class HomeController : Controller
    {
        [Route("Index.cshtml")]
        [Route("Home")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/Contact")]
        [Route("Contact.cshtml")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("Home/About")]
        [Route("About.cshtml")]
        public IActionResult About()
        {
            return View();
        }
    }
}
