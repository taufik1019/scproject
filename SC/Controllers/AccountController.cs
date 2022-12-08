using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SC.Repositories.Data;
using SC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Controllers
{
    public class AccountController : Controller
    {
        AccountRepository accountRepository;
        public AccountController(AccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login login)
        {
            // statement mengambil data dari database sesuai dengan email dan password
            var data = accountRepository.Login(login);
            if (data != null)
            {
                HttpContext.Session.SetString("Role", data.Role);
                HttpContext.Session.SetString("iduser", data.Id.ToString());
                if (data.IdRole == 1)
                {
                    return RedirectToAction("Index", "Keluhan");
                } else if(data.IdRole == 2)
                {
                    return RedirectToAction("Index", "Mhs");
                }
                
            }
            return View();
           

        }

    }
}
