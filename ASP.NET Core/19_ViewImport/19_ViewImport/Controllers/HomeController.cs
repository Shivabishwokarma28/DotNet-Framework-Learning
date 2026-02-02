using _19_ViewImport.Model;
using Microsoft.AspNetCore.Mvc;

namespace _19_ViewImport.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        public IActionResult Index()
        {
            var td = new List<Teacher>
             {
                new Teacher { Id = 1001,Name="Devendra",T_Address="Tamghas" },
                new Teacher { Id = 1002, Name = "Mandeep", T_Address = "Tamghas" }

            }
            ;
            return View(td);
        }
        public IActionResult About()
        {
            var td = new List<Teacher>
             {
                new Teacher { Id = 1001,Name="Devendra",T_Address="Tamghas" },
                new Teacher { Id = 1002, Name = "Mandeep", T_Address = "Tamghas" }

            }
            ;
            return View(td);
        }
        public IActionResult Contact()
        {
            var td = new List<Teacher>
             {
                new Teacher { Id = 1001,Name="Devendra",T_Address="Tamghas" },
                new Teacher { Id = 1002, Name = "Mandeep", T_Address = "Tamghas" }

            }
           ;
            return View(td);
        }
    }
}
