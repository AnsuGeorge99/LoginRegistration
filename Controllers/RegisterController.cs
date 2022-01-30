
using LoginRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginRegistration.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        LoginDbEntities db = new LoginDbEntities();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SaveData(SiteUser model)
        {
            db.SiteUsers.Add(model);
            db.SaveChanges();
            return Json("Registration Successful", JsonRequestBehavior.AllowGet);
        }
    }
}