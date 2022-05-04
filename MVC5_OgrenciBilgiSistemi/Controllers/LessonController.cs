using MVC5_OgrenciBilgiSistemi.Models;
using System.Linq;
using System.Web.Mvc;

namespace Gym_MVC.Controllers
{
    public class LessonController : Controller
    {
        // GET: Personel
        MVC5_OgrenciBilgiSistemi.Models.SCHOOLEntities1 db = new MVC5_OgrenciBilgiSistemi.Models.SCHOOLEntities1();
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