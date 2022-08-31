﻿using DesafioGrantoSeguros.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrantoSeguros.Domain.Interfaces.Repositories
{
    public interface IVendedorRepository
    {
        Task<Vendedor> GetVendedorAsync(int id);
        Task<IEnumerable<Vendedor>> GetVendedoresAsync();
        Task<Vendedor> InsertVendedorAsync(Vendedor vendedor);
    }
}
