using SOL_JUAN_EDUARDO_SERRANO.Models;
using SOL_JUAN_EDUARDO_SERRANO.Utils;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.DataAccess
{
    public class SeccionData
    {
        public List<Seccion> ListadoSeccion(int cboCurso)
        {
            List<Seccion> listaSeccion = new List<Seccion>();

            string queryString = "SELECT ID_SECCION,NOMBRE FROM SECCION WHERE ID_CURSO = " + cboCurso + " AND ESTADO = 1";
            using (OracleConnection connection = new OracleConnection(Conexion.con))
            {
                OracleCommand command = new OracleCommand(queryString, connection);
                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        listaSeccion.Add(new Seccion()
                        {
                            ID_SECCION = Convert.ToInt32(reader["ID_SECCION"].ToString()),
                            NOMBRE = reader["NOMBRE"].ToString()
                        });
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return listaSeccion;
        }
    }
}