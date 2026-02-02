using System.Diagnostics;
using _28_CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace _28_CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext studentDB;

        public HomeController(StudentDbContext studentDB)
        {
            this.studentDB = studentDB;
        }
        public async Task<IActionResult> Index()
        {
            var stud = await studentDB.Students.ToListAsync();
            return View(stud);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult> Create(Student std)
        {
            if(ModelState.IsValid)
            {
                await studentDB.Students.AddAsync(std);
               await  studentDB.SaveChangesAsync();
                TempData["inserted_success"] = "Inserted..";
                return RedirectToAction("Index","Home");
            }
            return View(std);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if(id==null|| studentDB.Students==null)
            { 
                return NotFound();
            }
            var stud=await studentDB.Students.FirstOrDefaultAsync(x=>x.Id==id);
            return View(stud);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            var stud = await studentDB.Students.FindAsync(id);
            return View(stud);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Student std)
        {
            if(id!=std.Id)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                studentDB.Students.Update(std);
                await studentDB.SaveChangesAsync();
                TempData["update_success"] = "Updated..";
                return RedirectToAction("Index","Home");
            }
           
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id ==null || studentDB.Students==null)
            {
                return NotFound();
            }
           
            var stud = await studentDB.Students.FirstOrDefaultAsync(x=>x.Id==id);
            if ( stud == null)
            {
                return NotFound();
            }
            return View(stud);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteData(int? id)
        {
            var stdData = await studentDB.Students.FindAsync(id);
           
            if(stdData!=null)
            {
                studentDB.Students.Remove(stdData);
            }
            await studentDB.SaveChangesAsync();
            TempData["delete_success"] = "Deleted..";

            return RedirectToAction("Index","Home");
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
