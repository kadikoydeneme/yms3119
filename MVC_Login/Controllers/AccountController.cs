using MVC_Login.Models.Data.Context;
using MVC_Login.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Login.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            //kullanıcı oturum açtığında
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        ProjectContext db = new ProjectContext();

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Login(LoginVM model)
        {
            //Model kontrolü
            if (ModelState.IsValid)
            {
                var kullanici = db.User.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);

                if (kullanici != null)
                {
                    //cookie oluşturma cookie bazlı veri tutma. 2880 saniyelik oturum bazlı veri tutma sistemi kullanır.
                    FormsAuthentication.SetAuthCookie(kullanici.Name, true);

                    return RedirectToAction("Index", "home");
                }

            }

            ViewBag.Message = "E-Posta veya Paralo Yanlış.";
            return View();
        }

        public ActionResult LogOut()
        {
            //Oturumdan güvenli çıkış
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Account");
        }



    }
}