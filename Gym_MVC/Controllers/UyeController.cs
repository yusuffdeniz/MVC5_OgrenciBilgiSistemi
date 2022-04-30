using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym_MVC.Models;

namespace Gym_MVC.Controllers
{
    public class UyeController : Controller
    {
        SportCenterEntities db = new SportCenterEntities();
        public ActionResult UyeListesi()
        {
            var uyeler = db.Members.ToList();
            return View(uyeler);

        }
      //   [HttpPost]
        public ActionResult AddMember()
        {
            return View();
        }
    }
}