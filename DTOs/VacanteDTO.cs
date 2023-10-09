using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.DTOs
{
    public class VacanteDTO
    {
        public int ID_VACANTE { get; set; }
        public int ID_CURSO { get; set; }
        public int ID_SECCION { get; set; }
        public int VACANTES_DISPONIBLES { get; set; }
        public string NOMBRE_CURSO { get; set; }
        public int CREDITOS { get; set; }
        public string NOMBRE_SECCION { get; set; }
    }
}