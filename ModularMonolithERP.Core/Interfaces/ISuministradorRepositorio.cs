﻿using ModularMonolithERP.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithERP.Core.Interfaces
{
    public interface ISuministradorRepositorio
    {
        Task CrearSuministrador(SuministradorModel suministrador);
        Task<IEnumerable<SuministradorModel>> ObtenerListadoSuministradorAsync();
    }
}