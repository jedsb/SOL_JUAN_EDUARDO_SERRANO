using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.DTOs
{
    public class MatriculaDTO
    {
        public int ID_MATRICULA { get; set; }
        public int ID_ALUMNO { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public int ID_CURSO { get; set; }
        public string NOMBRE_CURSO { get; set; }
        public int ID_SECCION { get; set; }        
        public int CREDITOS { get; set; }
        public string NOMBRE_SECCION { get; set; }
        public string TIPO_MATRICULA { get; set; }
        public string FECHA_MATRICULA { get; set; }
        public string FECHA_ANULACION { get; set; }
    }
}