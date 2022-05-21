using MVC_OgrenciBilgiSistemi.Models;
using System.Linq;
using System.Web.Mvc;

namespace MVC_OgrenciBilgiSistemi
{
    public class MVC_OgrenciBilgiSistemi : Controller
    {
        // GET: Personel
        Models.SCHOOLEntities1 db = new Models.SCHOOLEntities1();
        public ActionResult List()
        {
            var lesson = db.Lessons.ToList();

            return View(lesson);
        }
        [HttpGet]
        public ActionResult Add()

        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Lesson l)
        {
            db.Lessons.Add(l);
            db.SaveChanges();
            return View();
        }
    }
}
