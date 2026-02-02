using System.Diagnostics;
using _31_LoginFormASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace _31_LoginFormASPCore.Controllers
{
    public class HomeController : Controller
    {
      
        private readonly MicrosoftContext mcontext;

        public HomeController(MicrosoftContext mcontext)
        {
            this.mcontext = mcontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
          
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public IActionResult Login(UserTbl user)
        {
            var myuser = mcontext.UserTbls.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
            if(myuser !=null)
            {
                HttpContext.Session.SetString("UserSession",myuser.Email);
                return RedirectToAction("Dashboard");
            }
            else
            { 
                ViewBag.Message = "Login Fail";

                var checkEmail = mcontext.UserTbls
       .FirstOrDefault(x => x.Email.Trim().ToLower() == user.Email.Trim().ToLower());
                //var checkEmail=mcontext.UserTbls.Where(x => x.Email != user.Email).FirstOrDefault();
                if (checkEmail==null)
                {
                    ViewBag.ErrorEmail = "Incorrect Email";
                }

                else if (checkEmail.Password != user.Password)
                {
                    ViewBag.ErrorEmail = "Invalid Password";
                }
               
            }
                return View();
        }

        public IActionResult Dashboard()
        {
            if (
            HttpContext.Session.GetString("UserSession")!=null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("UserSession").ToString();
            }
            else
            {
                return RedirectToAction("Login");
            }
                return View();
        }
        public IActionResult Logout()
        {
            if(HttpContext.Session.GetString("UserSession")!=null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserTbl user)
        {
            var emailexist = mcontext.UserTbls.Any(x => x.Email==user.Email);
            if(emailexist!=null)
            {
                ModelState.AddModelError("Email","Email already exist");
                return View(user);
            }    
            if(ModelState.IsValid)

            {
                await mcontext.UserTbls.AddAsync(user);
                await mcontext.SaveChangesAsync();
                TempData["Success"] = "Registered Successfully";
                return RedirectToAction("Login");
            }
            return View();
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
