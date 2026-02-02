using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace _05_ControllersandActions.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();//ViewResult, PartialViewResult,JsonResult
        }
        [Route("Home/Display")]
        public string Display()
        {
            return "This is controller display action method";
        }
        [Route("Home/Id/{id?}")]
        public int Id(int? id)
        {
            return id ?? 1;
        }

    }
}
