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
    public class PeriyodController : Controller
    {
        // GET: Periyod

        PeriyodManager p = new PeriyodManager(new EFPeriyodDal());

        [HttpGet]
        public ActionResult AddPeriyod()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPeriyod(Periyod p1)
        {


            PeriyodValidatior cv = new PeriyodValidatior();
            ValidationResult results = cv.Validate(p1);
            if (results.IsValid)
            {


                p.PeriyodAddBL(p1);
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