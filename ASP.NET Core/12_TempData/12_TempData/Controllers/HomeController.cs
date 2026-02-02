using Microsoft.AspNetCore.Mvc;

namespace _12_TempData.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        public IActionResult Index()
        {
            ViewData["data1"] = "ViewData";
            ViewBag.data2 = "ViewBag";
            TempData["data3"] = "TempData";
            TempData.Keep();//Now tempdata can't be killed
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
////ViewData["data1"] = "Shiva";
////ViewData["data2"] = 20;
//ViewData["data3"] = DateTime.Now.ToLongDateString();
////string[] array = { "Guitar", "Laptop", "Books", "Pen", "Drawing", "Coding" };
////ViewData["data4"] = array;
//List<string> lis = new List<string>() { "Football", "Cricket", "Basketball", "Tabletenis" };
//ViewData["data5"] = lis;
//ViewBag.data1 = "Shiva";
//ViewBag.data2 = new List<string>() { "Guitar", "Laptop", "Books", "Coding" };