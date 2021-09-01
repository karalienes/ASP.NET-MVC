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
    public class TraningTypeController : Controller
    {
        // GET: TraningType
       
            TraningTypeManager Tt = new TraningTypeManager(new EFTraningTypeDal());

            [HttpGet]
            public ActionResult AddTraningType()
            {
                return View();
            }
            [HttpPost]
            public ActionResult AddTraningType(TraningType tt1)
            {


            TraningTypeValidatior cv = new TraningTypeValidatior();
            ValidationResult results = cv.Validate(tt1);
            if (results.IsValid)
            {


                Tt.TraningTypeAddBL(tt1);
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
