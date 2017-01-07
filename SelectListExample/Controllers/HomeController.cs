using SelectListExample.Infrastructure;
using System.Linq;
using System.Web.Mvc;

namespace SelectListExample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly Db _db;
        public HomeController(Db db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            SetUnsoldReasonsViewBag();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private void SetUnsoldReasonsViewBag()
        {
            var items = _db.UnsoldReasons.ToList();
            ViewBag.UnsoldReasons = items;
        }
    }
}