using SOL_JUAN_EDUARDO_SERRANO.DTOs;
using SOL_JUAN_EDUARDO_SERRANO.Utils;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.DataAccess
{
    public class VacanteData
    {
        public List<VacanteDTO> ListadoVacantes()
        {
            List<VacanteDTO> listaVacantes = new List<VacanteDTO>();

            string queryString = "SELECT V.ID_VACANTE,V.ID_CURSO,C.NOMBRE_CURSO,C.CREDITOS,";
            queryString = queryString + " V.ID_SECCION, S.NOMBRE AS NOMBRE_SECCION,V.VACANTES_DISPONIBLES ";
            queryString = queryString + " FROM VACANTE V ";
            queryString = queryString + " INNER JOIN CURSO C ON C.ID_CURSO = V.ID_CURSO ";
            queryString = queryString + " INNER JOIN SECCION S ON S.ID_SECCION = V.ID_SECCION ";
            queryString = queryString + " ORDER BY V.VACANTES_DISPONIBLES DESC ";

            using (OracleConnection connection = new OracleConnection(Conexion.con))
            {
                OracleCommand command = new OracleCommand(queryString, connection);
                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        listaVacantes.Add(new VacanteDTO()
                        {
                            ID_VACANTE = Convert.ToInt32(reader["ID_VACANTE"].ToString()),
                            ID_CURSO = Convert.ToInt32(reader["ID_CURSO"].ToString()),
                            ID_SECCION = Convert.ToInt32(reader["ID_SECCION"].ToString()),
                            VACANTES_DISPONIBLES = Convert.ToInt32(reader["VACANTES_DISPONIBLES"].ToString()),
                            NOMBRE_CURSO = reader["NOMBRE_CURSO"].ToString(),
                            CREDITOS = Convert.ToInt32(reader["CREDITOS"].ToString()),
                            NOMBRE_SECCION = reader["NOMBRE_SECCION"].ToString()
                        }); 
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return listaVacantes;
        }
    }
}