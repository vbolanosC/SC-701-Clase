﻿using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.DA
{
    public interface IEquipoDA
    {
        public Task<IEnumerable<Equipo>> ObtenerEquipos();
        public Task<Guid> Agregar(Entidades.Equipo equipo);
        public Task AgregarPokemonxEquipo(Abstracciones.Entidades.PokemonxEquipo pokemonxEquipo);
    }
}
