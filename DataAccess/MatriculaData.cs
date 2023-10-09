using SOL_JUAN_EDUARDO_SERRANO.DTOs;
using SOL_JUAN_EDUARDO_SERRANO.Models;
using SOL_JUAN_EDUARDO_SERRANO.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.DataAccess
{
    public class MatriculaData
    {
        public int RegistrarMatricula(int ID_ALUMNO, int ID_CURSO, int ID_SECCION, string TIPO_MATRICULA, DateTime FECHA_MATRICULA)
        {
            int resultado = 0;
            try
            {
                using (OracleConnection connection = new OracleConnection(Conexion.con))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("RegistrarMatricula", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.Add("P_ID_ALUMNO", OracleType.Int32).Value = ID_ALUMNO;
                        command.Parameters.Add("P_ID_CURSO", OracleType.Int32).Value = ID_CURSO;
                        command.Parameters.Add("P_ID_SECCION", OracleType.Number).Value = ID_SECCION;
                        command.Parameters.Add("P_TIPO_MATRICULA", OracleType.VarChar).Value = TIPO_MATRICULA;
                        command.Parameters.Add("P_FECHA_MATRICULA", OracleType.DateTime).Value = FECHA_MATRICULA; 
                        command.Parameters.Add("P_RESULTADO", OracleType.Number).Direction = ParameterDirection.Output;
                        command.ExecuteNonQuery();                        
                        resultado = Convert.ToInt32(command.Parameters["P_RESULTADO"].Value);

                    }
                }

            }
            catch (Exception ex)
            {
                resultado = -1;
            }
            return resultado;
        }

        public List<MatriculaDTO> ListaMatriculados()
        {
            List<MatriculaDTO> listaMatriculados = new List<MatriculaDTO>();

            string queryString = "SELECT M.ID_MATRICULA,M.ID_ALUMNO,A.NOMBRES,A.APELLIDOS, ";
            queryString = queryString + " M.ID_CURSO, C.NOMBRE_CURSO, C.CREDITOS, S.NOMBRE AS NOMBRE_SECCION, ";
            queryString = queryString + " M.TIPO_MATRICULA, M.FECHA_MATRICULA, M.FECHA_ANULACION  FROM MATRICULA M  ";
            queryString = queryString + " INNER JOIN ALUMNO A ON A.ID_ALUMNO = M.ID_ALUMNO ";
            queryString = queryString + " INNER JOIN CURSO C ON C.ID_CURSO = M.ID_CURSO ";
            queryString = queryString + " INNER JOIN SECCION S ON S.ID_SECCION = M.ID_SECCION ORDER BY M.ID_MATRICULA ASC ";

            using (OracleConnection connection = new OracleConnection(Conexion.con))
            {
                OracleCommand command = new OracleCommand(queryString, connection);
                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        listaMatriculados.Add(new MatriculaDTO()
                        {
                            ID_MATRICULA = Convert.ToInt32(reader["ID_MATRICULA"].ToString()),
                            ID_ALUMNO = Convert.ToInt32(reader["ID_ALUMNO"].ToString()),
                            NOMBRES = reader["NOMBRES"].ToString(),
                            APELLIDOS = reader["APELLIDOS"].ToString(),
                            ID_CURSO = Convert.ToInt32(reader["ID_CURSO"].ToString()),
                            NOMBRE_CURSO = reader["NOMBRE_CURSO"].ToString(),
                            CREDITOS = Convert.ToInt32(reader["CREDITOS"].ToString()),
                            NOMBRE_SECCION = reader["NOMBRE_SECCION"].ToString(),
                            TIPO_MATRICULA = reader["TIPO_MATRICULA"].ToString(),
                            FECHA_MATRICULA = reader["FECHA_MATRICULA"].ToString(),
                            FECHA_ANULACION = reader["FECHA_ANULACION"].ToString() ?? "-"

                        }) ;
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return listaMatriculados;
        }
    }
}