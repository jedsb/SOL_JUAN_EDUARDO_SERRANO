using SOL_JUAN_EDUARDO_SERRANO.Logic;
using SOL_JUAN_EDUARDO_SERRANO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOL_JUAN_EDUARDO_SERRANO.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult ListadoCurso()
        {
            List<Curso> listaCurso = new List<Curso>();
            listaCurso = new CursoLogic().ListadoCursos();

            return Json(new { data = listaCurso }, JsonRequestBehavior.AllowGet);

        }
    }
}