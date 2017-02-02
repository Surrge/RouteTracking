using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouteTracking.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult MapTesting(double? lat, double? lng)
        {
            return lat.HasValue && lng.HasValue
                ? View(new Tuple<double, double>(lat.Value, lng.Value))
                : View(new Tuple<double, double>(-34.397, 150.644));
        }
    }
}