using Microsoft.AspNetCore.Mvc;

namespace _03_RoutingWithoutMVC.Controllers
{
    // [Route("Home")]
    [Route("[Controller]/[Action]")]//Controller token
    public class HomeController : Controller
    {
        [Route("")]//Attribute Routing
        [Route("~/")]//for empty url
        //[Route("Home/Index")]
        //[Route("[Action]")]
        [Route("~/Home")]//for empty url
        public IActionResult Index()
        {
            return View();
        }
        //[Route("[Action]")]
        //[Route("AboutUs")]
        
        public IActionResult About()
        {
            return View();
        }
        //[Route("[Action]/{id?}")] //Action token
        //[Route("Id/{id?}")] 
        public int Detail(int? id)
        {
            return id ?? 1;
        }
    }
}
