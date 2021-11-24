using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioPropuesto1.Controllers
{
    public class ProductosController : Controller
    {
        [Authorize]
        // GET: Productos
        public ActionResult mostrarproductos()
        {
            return View();
        }
    }
}