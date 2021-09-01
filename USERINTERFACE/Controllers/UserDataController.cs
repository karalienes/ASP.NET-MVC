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
using USERINTERFACE.Models;

namespace USERINTERFACE.Controllers
{
     
    public class UserDataController : Controller
    {
        UserDataManager udm = new UserDataManager(new EFUserDataDal());
        PeriyodManager p = new PeriyodManager(new EFPeriyodDal());
        TraningManager t = new TraningManager(new EFTraningDal());
        TraningTypeManager Ty = new TraningTypeManager(new EFTraningTypeDal());
        TraningİnfoManager Ti = new TraningİnfoManager(new EFTraningİnfoDal());
        // GET: UserData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetUserDataList()
        {
            Birleştirici br = new Birleştirici();
            br.Periyods = p.GetListBL();
            br.Tranings = t.GetListBL();
            br.UserDatas = udm.GetListBL();
            br.TraningTypes = Ty.GetListBL();
            br.Traningİnfos = Ti.GetListBL();
            return View(br);
        }

        [HttpGet]
        public ActionResult AddUserData()
        {

            //List<SelectListItem> kategoriler = new List<SelectListItem>();

            //foreach (var item in p.GetListBL())
            //{   //Text = Görünen kısımdır. Kategori ismini yazdıyoruz
            //    //Value = Değer kısmıdır.ID değerini atıyoruz
            //    kategoriler.Add(new SelectListItem { Text = item.Hafta, Value = item.Hafta.ToString() });
            //    kategoriler.Add(new SelectListItem { Text = item.Ay, Value = item.Ay.ToString() });
            //    kategoriler.Add(new SelectListItem { Text = item.Yıl, Value = item.Yıl.ToString() });
            //}


            //@Html.DropDownList("kategoriler", new SelectList(ViewBag.Kategoriler, "Value", "Text"), "Kategori Seçiniz", new { @class = "form-control" })



            List<SelectListItem> ıtems =
               (List<SelectListItem>)(from i in udm.GetListBL()
                select new SelectListItem
                {
                    Text = i.AdSoyad,
                    Value = i.AdSoyad.ToString(),

                }
                
                ).GroupBy(x=>x.Text).Select(x=>x.First()).ToList();
            ViewBag.Items = ıtems;

            //List<SelectListItem> ıtems2 =
            //   (List<SelectListItem>)(from i in p.GetListBL()
            //    select new SelectListItem
            //    {
            //        Text = i.Hafta,
            //        Value = i.Hafta.ToString(),

            //    }
            //    ).GroupBy(x => x.Text).Select(x => x.First()).ToList();
            //ViewBag.Items2 = ıtems2;

            //List<SelectListItem> ıtems3 =
            //   (List<SelectListItem>)(from i in p.GetListBL()
            //    select new SelectListItem
            //    {
            //        Text = i.Ay,
            //        Value = i.Ay.ToString(),

            //    }
            //    ).GroupBy(x => x.Text).Select(x => x.First()).ToList();
            //ViewBag.Items3 = ıtems3;

            //List<SelectListItem> ıtems4 =
            //  (List<SelectListItem>)(from i in p.GetListBL()
            //   select new SelectListItem
            //   {
            //       Text = i.Yıl,
            //       Value = i.Yıl.ToString(),

            //   }
            //   ).GroupBy(x => x.Text).Select(x => x.First()).ToList();
            //ViewBag.Items4 = ıtems4;


            List<SelectListItem> ıtems4 =
             (List<SelectListItem>)(from i in p.GetListBL()
                                    select new SelectListItem
                                    {
                                        Text = i.Hafta.ToString() + " " + i.Ay.ToString() + " " + i.Yıl.ToString(),
                                        Value = i.PeriyodId.ToString(),

                                    }
              ).ToList();
            ViewBag.Items4 = ıtems4;

            List<SelectListItem> ıtems5 =
              (List<SelectListItem>)(from i in t.GetListBL()
               select new SelectListItem
               {
                   Text = i.TraningName,
                   Value = i.TraningName.ToString(),

               }
               ).GroupBy(x => x.Text).Select(x => x.First()).ToList();
            ViewBag.Items5 = ıtems5;

            List<SelectListItem> ıtems6 =
             (List<SelectListItem>)(from i in Ty.GetListBL()
              select new SelectListItem
              {
                  Text = i.TraningTypee,
                  Value = i.TraningTypee.ToString(),

              }
              ).GroupBy(x => x.Text).Select(x => x.First()).ToList();
            ViewBag.Items6 = ıtems6;

            return View();
        }
        [HttpPost]
        public ActionResult AddUserData( Traningİnfo Ti1)

        {
            //var PeriyodValue = ViewBag.Items4;

            //List<SelectListItem> ıtems =
            //(List<SelectListItem>)(from i in udm.GetListBL()
            //                       select new SelectListItem
            //                       {
            //                           Text = i.AdSoyad,
            //                           Value = i.AdSoyad.ToString(),

            //                       }

            // ).GroupBy(x => x.Text).Select(x => x.First()).ToList();
            //ViewBag.Items = ıtems;

            //List<SelectListItem> ıtems4 =
            //  (List<SelectListItem>)(from i in p.GetListBL()
            //                         select new SelectListItem
            //                         {
            //                             Text = i.Hafta.ToString()+" "+ i.Ay.ToString()+ " " + i.Yıl.ToString(),
            //                             Value = i.PeriyodId.ToString(),

            //                         }
            //   ).ToList();
            //ViewBag.Items4 = ıtems4;

            //List<SelectListItem> ıtems5 =
            //  (List<SelectListItem>)(from i in t.GetListBL()
            //                         select new SelectListItem
            //                         {
            //                             Text = i.TraningName,
            //                             Value = i.TraningName.ToString(),

            //                         }
            //   ).GroupBy(x => x.Text).Select(x => x.First()).ToList();
            //ViewBag.Items5 = ıtems5;

            //List<SelectListItem> ıtems6 =
            // (List<SelectListItem>)(from i in Ty.GetListBL()
            //                        select new SelectListItem
            //                        {
            //                            Text = i.TraningTypee,
            //                            Value = i.TraningTypee.ToString(),

            //                        }
            //  ).GroupBy(x => x.Text).Select(x => x.First()).ToList();
            //ViewBag.Items6 = ıtems6;

            

            TraningİnfoValidatior cv = new TraningİnfoValidatior();
            ValidationResult results = cv.Validate(Ti1);
            if (results.IsValid)
            {

                Ti1.CreateTime = DateTime.Now;
                Ti.TraningİnfoAddBL(Ti1);
                return RedirectToAction("GetUserDataList");
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

        public ActionResult FilterSearch(string search)
        {
            Birleştirici br = new Birleştirici();
            
            var model =udm.GetListBL();
            
            
            if (!string.IsNullOrEmpty(search))
            {
                model= model.Where(x => x.AdSoyad.Contains(search)).ToList();
                
            }

           
            br.Periyods = p.GetListBL();
            br.Tranings = t.GetListBL();
            br.Traningİnfos = Ti.GetListBL();
            br.TraningTypes = Ty.GetListBL();
            //br.UserDatas = model;

            br.UserDatas =
            (IEnumerable<UserData>)(br.UserDatas = (IEnumerable<UserData>)model);
            return View(br);
        }
        
        public ActionResult Delete(int ıd)
        {
          
            var Traningİnfovalue = Ti.GetByİşlemSıra(ıd);
            Ti.TraningİnfoDelete(Traningİnfovalue);
            return RedirectToAction("GetUserDataList");
        }
        [HttpGet]
        public ActionResult UpdateUserData(int ıd, int ıd2,int ıd3, int ıd4,int ıd5)
        {
            var Traningİnfovalue = Ti.GetByİşlemSıra(ıd4);
            //var periyodvalue = p.GetByİşlemSıra(ıd2);
            //var traningvalue = t.GetByİşlemSıra(ıd3);
            //if (Traningİnfovalue.TraningİnfoId == ıd4)
            //{


            //}

            //List<SelectListItem> ıtems4 =
            // (List<SelectListItem>)(from i in p.GetListBL()
            //                        select new SelectListItem
            //                        {
            //                            Text = i.Hafta.ToString() + " " + i.Ay.ToString() + " " + i.Yıl.ToString(),
            //                            Value = i.PeriyodId.ToString(),

            //                        }
            //  ).ToList();
            //ViewBag.Items4 = ıtems4;

            return View(Traningİnfovalue);
        }
        [HttpPost]
        public ActionResult UpdateUserData(UserData ud, Periyod p1, Traning t1, Traningİnfo Ti1, TraningType Tt1)
        {
           

            udm.USerDataUpdate(Ti1.UserData);
            p.PeriyodUpdate(Ti1.Periyod);
            t.TraningUpdate(Ti1.Traning);
            Ty.TraningTypeUpdate(Ti1.Traning.TraningTypes);
            Ti.TraningİnfoUpdate(Ti1);
            

            return RedirectToAction("GetUserDataList");
        }

        public ActionResult Back()
        {
            
            return RedirectToAction("GetUserDataList");
        }
    }
}