using SOL_JUAN_EDUARDO_SERRANO.DataAccess;
using SOL_JUAN_EDUARDO_SERRANO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.Logic
{
    public class VacanteLogic
    {
        private VacanteData objvacanteData = new VacanteData();
        public List<VacanteDTO> ListadoVacantes()
        {
            return objvacanteData.ListadoVacantes();
        }
    }
}