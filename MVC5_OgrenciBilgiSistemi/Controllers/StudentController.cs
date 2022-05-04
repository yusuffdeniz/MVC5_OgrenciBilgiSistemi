using MVC5_OgrenciBilgiSistemi.Models;
using System.Linq;
using System.Web.Mvc;
namespace Gym_MVC.Controllers
{
    public class StudentController : Controller
    {
        MVC5_OgrenciBilgiSistemi.Models.SCHOOLEntities1 db = new MVC5_OgrenciBilgiSistemi.Models.SCHOOLEntities1();

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