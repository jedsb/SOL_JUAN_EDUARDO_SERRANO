using SOL_JUAN_EDUARDO_SERRANO.Logic;
using SOL_JUAN_EDUARDO_SERRANO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOL_JUAN_EDUARDO_SERRANO.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult BuscarAlumno(string dni)
        {
            Alumno alumno = new Alumno();
            alumno = new AlumnoLogic().buscarAlumno(dni);

            return Json(new {ID_ALUMNO = alumno.ID_ALUMNO, NOMBRES = alumno.NOMBRES, APELLIDOS = alumno.APELLIDOS });

        }
    }
}