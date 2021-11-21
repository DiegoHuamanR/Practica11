using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioPropuesto2.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SetCookie(string valor)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description of Enterprise DDA.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contactanos en:";

            return View();
        }
    }
}