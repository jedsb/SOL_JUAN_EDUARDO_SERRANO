﻿using SOL_JUAN_EDUARDO_SERRANO.DataAccess;
using SOL_JUAN_EDUARDO_SERRANO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOL_JUAN_EDUARDO_SERRANO.Logic
{
    public class CursoLogic
    {
        private CursoData objcursoData = new CursoData();
        public List<Curso> ListadoCursos()
        {
            return objcursoData.ListadoCursos();
        }
    }
}