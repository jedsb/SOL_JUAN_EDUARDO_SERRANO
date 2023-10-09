using SOL_JUAN_EDUARDO_SERRANO.DataAccess;
using SOL_JUAN_EDUARDO_SERRANO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.Logic
{
    public class AlumnoLogic
    {
        private AlumnoData objalumnoData = new AlumnoData();
        public Alumno buscarAlumno(string dni)
        {
            return objalumnoData.buscarAlumno(dni);
        }
    }
}