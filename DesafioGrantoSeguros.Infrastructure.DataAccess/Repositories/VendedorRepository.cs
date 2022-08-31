using DesafioGrantoSeguros.Domain.Entities;
using DesafioGrantoSeguros.Domain.Interfaces.Repositories;
using DesafioGrantoSeguros.Infrastructure.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace DesafioGrantoSeguros.Infrastructure.DataAccess.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly DesafioContext _context;

        public VendedorRepository(DesafioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Vendedor>> GetVendedoresAsync()
        {
            return await _context.Vendedores.AsNoTracking().ToListAsync();
        }

        public async Task<Vendedor> GetVendedorAsync(int id)
        {
            return await _context.Vendedores.FirstOrDefaultAsync(v => v.Id == id);
        }

    }
}
