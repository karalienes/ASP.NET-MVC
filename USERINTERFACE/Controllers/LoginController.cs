using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace USERINTERFACE.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserData l)
        {
            Context c = new Context();
            var loginuserinfo = c.UserDatas.FirstOrDefault(x => x.Mail == l.Mail && x.Şifre == l.Şifre);
            if(loginuserinfo != null)
            {
                return RedirectToAction("Index", "UserData");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

    }
}