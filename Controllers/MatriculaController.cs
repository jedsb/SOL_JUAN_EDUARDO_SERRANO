using SOL_JUAN_EDUARDO_SERRANO.DTOs;
using SOL_JUAN_EDUARDO_SERRANO.Logic;
using SOL_JUAN_EDUARDO_SERRANO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOL_JUAN_EDUARDO_SERRANO.Controllers
{
    public class MatriculaController : Controller
    {
        
        // GET: Matricula
        public ActionResult Matricula()
        {
            return View();
        }

        [HttpPost]
        public JsonResult RegistrarMatricula(int ID_ALUMNO, int ID_CURSO, int ID_SECCION, string TIPO_MATRICULA,DateTime FECHA_MATRICULA)
        {
            MatriculaLogic matriculaLogic = new MatriculaLogic();
            int resultado = 0;
            resultado = matriculaLogic.RegistrarMatricula(ID_ALUMNO, ID_CURSO, ID_SECCION, TIPO_MATRICULA, FECHA_MATRICULA);

            return Json(new { resultado = resultado }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ReporteMatriculados()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ReporteMatricula()
        {
            List<MatriculaDTO> listaMatriculados = new List<MatriculaDTO>();
            listaMatriculados = new MatriculaLogic().ListaMatriculados();

            return Json(new { data = listaMatriculados }, JsonRequestBehavior.AllowGet);

        }

    }
}