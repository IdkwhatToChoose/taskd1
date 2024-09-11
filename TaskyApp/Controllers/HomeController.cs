using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskyApp.Models;
using TaskyApp.Model;
using TaskyApp.ViewModels;
using TaskyApp.Helps;

namespace TaskyApp.Controllers
{
    public class HomeController : Controller
    {
        private Taskd1Context db=new Taskd1Context();
        private readonly ITaskMapper taskMapper;
        //public string pass = "";
        public HomeController(ITaskMapper _clMapper)
        {
            taskMapper = _clMapper;
        }
        public IActionResult Index(bool isLoginI)
        {
            ViewBag.IsLogin = isLoginI;
            List<TaskProp> taskProp = db.TaskProps.ToList();
            List<TaskPropViewModel> taskPropViews = taskMapper.ListClientToListEstateVm(taskProp);

            return View(taskPropViews);
        }
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View("/Views/Home/Login.cshtml");
        }
        public IActionResult RegistrationAdd(RegisteredAccount account) {
        
            RegisteredAccount newAccount = new RegisteredAccount();
            newAccount.Email = account.Email;
            newAccount.Password = account.Password;
            db.RegisteredAccounts.Add(newAccount);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public IActionResult LoginAccount(RegistrationViewModel rvm) 
        {
            RegisteredAccount? account = db.RegisteredAccounts.FirstOrDefault(x=>x.Email==rvm.Email);
            string textPass = rvm.Password;
            bool isLogin = false;
            rvm.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            if (BCrypt.Net.BCrypt.Verify(textPass, rvm.Password) == true)
            {
                isLogin = true;
                return RedirectToAction("Index", "Home", new {isLoginI=isLogin});
            }
            return RedirectToAction("Index", "Home", new { isLoginI = isLogin });
            
        }
       
    }
}