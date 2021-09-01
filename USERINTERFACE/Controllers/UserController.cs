using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace USERINTERFACE.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserDataManager Ud = new UserDataManager(new EFUserDataDal());

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(UserData ud1)
        {

            UserDataValidatior cv = new UserDataValidatior();
            ValidationResult results = cv.Validate(ud1);
            if (results.IsValid)
            {


                Ud.UserDataAddBL(ud1);
                return RedirectToAction("GetUserDataList", "UserData");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
    }
}