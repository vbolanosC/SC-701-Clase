﻿using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.BC
{
    public interface IEquipoBC
    {
        Task<int> GenerarEquipos(IEnumerable<Entrenador> entrenadores, IEnumerable<Pokemon> pokemon);
    }
}
