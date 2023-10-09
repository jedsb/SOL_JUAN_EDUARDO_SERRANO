using SOL_JUAN_EDUARDO_SERRANO.DataAccess;
using SOL_JUAN_EDUARDO_SERRANO.DTOs;
using SOL_JUAN_EDUARDO_SERRANO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.Logic
{
    public class MatriculaLogic
    {
        private MatriculaData objmatriculaData = new MatriculaData();
       
        public int RegistrarMatricula(int ID_ALUMNO, int ID_CURSO, int ID_SECCION, string TIPO_MATRICULA, DateTime FECHA_MATRICULA)
        {
            return objmatriculaData.RegistrarMatricula(ID_ALUMNO, ID_CURSO, ID_SECCION, TIPO_MATRICULA, FECHA_MATRICULA);
        }
        public List<MatriculaDTO> ListaMatriculados()
        {
            return objmatriculaData.ListaMatriculados();
        }

    }
}