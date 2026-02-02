using Microsoft.AspNetCore.Mvc;

namespace _18_InstallingBootstrapTailwindjQuery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
