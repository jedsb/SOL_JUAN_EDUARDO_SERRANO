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
    public class VacanteController : Controller
    {
        // GET: Vacante
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ListadoVacantes()
        {
            List<VacanteDTO> listaVacantes = new List<VacanteDTO>();
            listaVacantes = new VacanteLogic().ListadoVacantes();            
            return Json(new { data = listaVacantes }, JsonRequestBehavior.AllowGet);
        }
    }
}