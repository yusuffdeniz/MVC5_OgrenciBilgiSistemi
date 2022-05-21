using MVC_OgrenciBilgiSistemi.Models;
using System.Linq;
using System.Web.Mvc;
namespace MVC_OgrenciBilgiSistemi
{
    public class StudentController : Controller
    {
        Models.SCHOOLEntities1 db = new Models.SCHOOLEntities1();

        [HttpGet]
        public ActionResult List()
        {
            var ogrliste = db.Students.ToList();

            return View(ogrliste);

        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Student S)
        {
            db.Students.Add(S);
            db.SaveChanges();
            return View();
        }


    }
}
