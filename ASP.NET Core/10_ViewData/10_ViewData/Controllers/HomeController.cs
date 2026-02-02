using Microsoft.AspNetCore.Mvc;

namespace _10_ViewData.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        public IActionResult Index()
        {
            ViewData["data1"] = "Shiva";
            ViewData["data2"] = 20;
            ViewData["data3"] = DateTime.Now.ToLongDateString();
            string[] array = { "Guitar","Laptop","Books","Pen","Drawing","Coding"};
            ViewData["data4"] = array;
            List<string> lis= new List<string>() { "Football","Cricket","Basketball","Tabletenis"};
            ViewData["data5"]=lis;
            TempData["tempp"] = "TempData ";
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
