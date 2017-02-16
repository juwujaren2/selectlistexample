using System.Collections.Generic;
using SelectListExample.Infrastructure;
using System.Linq;
using System.Web.Mvc;
using Business;

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

        public JsonResult GetUnitDataJson(string q)
        {
            List<UserLocationUnit> data = _db.UserLocationUnits.Where(x => x.UserLocation.ToLower().Contains(q.ToLower()) || x.ManagerLastName.ToLower().Contains(q.ToLower())).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private void SetUnsoldReasonsViewBag()
        {
            var items = _db.UnsoldReasons.Where(x => x.Text.ToLower() != "other").OrderBy(x => x.Text).ToList();
            var otherReason = _db.UnsoldReasons.FirstOrDefault(x => x.Text.ToLower() == "other");
            ViewBag.OtherReason = otherReason;
            ViewBag.UnsoldReasons = items;
        }
    }
}