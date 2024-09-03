using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskyApp.Models;
using TaskyApp.Model;

namespace TaskyApp.Controllers
{
    public class HomeController : Controller
    {
        private Taskd1Context db=new Taskd1Context();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult RegistrationAdd(RegisteredAccount account) {
        
            RegisteredAccount newAccount = new RegisteredAccount();
            newAccount.Email = account.Email;
            newAccount.Password = account.Password;
            db.RegisteredAccounts.Add(newAccount);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
       
    }
}