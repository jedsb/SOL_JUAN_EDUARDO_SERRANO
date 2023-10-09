using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.Models
{
    public class Vacante
    {
        public int ID_VACANTE { get; set; }
        public int ID_CURSO { get; set; }
        public int ID_SECCION { get; set; }
        public int VACANTES_DISPONIBLES { get; set; }
        public int VACANTES_USADAS { get; set; }
    }
}