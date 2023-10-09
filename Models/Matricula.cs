using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.Models
{
    public class Matricula
    {
        public int ID_MATRICULA { get; set; }
        public int ID_ALUMNO { get; set; }
        public int ID_CURSO { get; set; }
        public int ID_SECCION { get; set; }
        public string TIPO_MATRICULA { get; set; }
        public DateTime FECHA_MATRICULA { get; set; }
        public DateTime FECHA_ANULACION { get; set; }
    }
}