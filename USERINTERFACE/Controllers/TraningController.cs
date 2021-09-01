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
    public class TraningController : Controller
    {
        // GET: Traning
        TraningManager t = new TraningManager(new EFTraningDal());
        [HttpGet]
        public ActionResult AddTraning()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTraning(Traning t1)
        {

            TraningValidatior cv = new TraningValidatior();
            ValidationResult results = cv.Validate(t1);
            if (results.IsValid)
            {


                t.TraningAddBL(t1);
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