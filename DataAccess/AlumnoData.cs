using SOL_JUAN_EDUARDO_SERRANO.Models;
using SOL_JUAN_EDUARDO_SERRANO.Utils;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.DataAccess
{
    public class AlumnoData
    {
        public Alumno buscarAlumno(string dni)
        {
            Alumno alumno = new Alumno();
            string queryString = "SELECT ID_ALUMNO, NOMBRES, APELLIDOS, ESTADO FROM ALUMNO WHERE DNI = '" + dni + "'";
            using (OracleConnection connection = new OracleConnection(Conexion.con))
            {
                OracleCommand command = new OracleCommand(queryString, connection);
                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {

                        alumno.NOMBRES = reader["NOMBRES"].ToString();
                        alumno.APELLIDOS = reader["APELLIDOS"].ToString();
                        alumno.ID_ALUMNO = Convert.ToInt32(reader["ID_ALUMNO"].ToString());
                    }
                }
                finally
                {                    
                    reader.Close();
                }
            }

            return alumno;

        }
    }
}