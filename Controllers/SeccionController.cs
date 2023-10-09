using SOL_JUAN_EDUARDO_SERRANO.Logic;
using SOL_JUAN_EDUARDO_SERRANO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOL_JUAN_EDUARDO_SERRANO.Controllers
{
    public class SeccionController : Controller
    {
        // GET: Seccion
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult ListadoSeccion(int cboCurso)
        {
            List<Seccion> listaSeccion = new List<Seccion>();
            listaSeccion = new SeccionLogic().ListadoSeccion(cboCurso);

            return Json(new { data = listaSeccion }, JsonRequestBehavior.AllowGet);

        }
    }
}