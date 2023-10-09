using SOL_JUAN_EDUARDO_SERRANO.Models;
using SOL_JUAN_EDUARDO_SERRANO.Utils;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.DataAccess
{
    public class CursoData
    {
        public List<Curso> ListadoCursos()
        {
            List<Curso> listaCurso = new List<Curso>();

            string queryString = "SELECT ID_CURSO,NOMBRE_CURSO FROM CURSO WHERE ESTADO = 1";
            using (OracleConnection connection = new OracleConnection(Conexion.con))
            {
                OracleCommand command = new OracleCommand(queryString, connection);
                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        listaCurso.Add(new Curso()
                        {
                            ID_CURSO = Convert.ToInt32(reader["ID_CURSO"].ToString()),
                            NOMBRE_CURSO = reader["NOMBRE_CURSO"].ToString()
                        });
                    }
                }
                finally
                {                    
                    reader.Close();
                }
            }       

            return listaCurso;
        }
    }
}