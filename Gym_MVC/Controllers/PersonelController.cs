using Gym_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gym_MVC.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        SportCenterEntities db = new SportCenterEntities();
        public ActionResult Liste()
        {
            var personel = db.Staffs.ToList();
            return View(personel);
        }
    }
}