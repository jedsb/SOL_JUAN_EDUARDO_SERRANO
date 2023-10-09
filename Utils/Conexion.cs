using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.Utils
{
   
    public class Conexion
    {               
                    
        //public static string con = "Data Source=BDPruebaUPC; User Id=SYSTEM;Password=123456; ";
        public static string con = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(Host=localhost)(Port=1521)))(CONNECT_DATA=(SID=xe))); User Id=SYSTEM;Password=123456; ";


    }
}