using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.Models
{
    public class Curso
    {
        public int ID_CURSO { get; set; }

        public string NOMBRE_CURSO { get; set; }
        public int CREDITOS { get; set; }
        public int ESTADO { get; set; }
    }
}