using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Login.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Otomatik olarak kullanıcının oturum açma durumunu kontrol eden yapı
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.CurrentUser = User.Identity.Name;

            return View();
        }
    }
}