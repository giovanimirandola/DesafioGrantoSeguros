﻿using DesafioGrantoSeguros.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrantoSeguros.Domain.Interfaces.Repositories
{
    public interface IOportunidadeRepository
    {
        Task<Oportunidade> GetOportunidadeAsync(int id);
        Task<IEnumerable<Oportunidade>> GetOportunidadesAsync();
        Task<Oportunidade> InsertOportunidadeAsync(Oportunidade oportunidade);
    }
}
