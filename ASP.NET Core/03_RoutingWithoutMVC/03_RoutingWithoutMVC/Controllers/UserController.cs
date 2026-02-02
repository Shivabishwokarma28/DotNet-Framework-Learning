using Microsoft.AspNetCore.Mvc;

namespace _03_RoutingWithoutMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
