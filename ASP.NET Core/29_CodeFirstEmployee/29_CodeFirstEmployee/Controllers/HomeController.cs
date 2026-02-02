using System.Diagnostics;
using _29_CodeFirstEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace _29_CodeFirstEmployee.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext emp;

        public HomeController(EmployeeDbContext emp)
        {
            this.emp = emp;
        }
        public IActionResult Index()
        {
            var empl = emp.Employees.ToList();
            return View(empl);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employe)
        {
            if(ModelState.IsValid)
            {
                emp.Employees.Add(employe);
                emp.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            return View(employe);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
