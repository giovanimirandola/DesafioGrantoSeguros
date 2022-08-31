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


        public async Task<Vendedor> InsertVendedorAsync(Vendedor vendedor)
        {
            await _context.Vendedores.AddAsync(vendedor);
            await _context.SaveChangesAsync();

            return vendedor;
        }

        public async Task<Vendedor> UpdateVendedorAsync(Vendedor vendedor)
        {
            var vendedorDB = await _context.Vendedores.FindAsync(vendedor.Id);

            if (vendedorDB == null)
                return null;

            _context.Entry(vendedorDB).CurrentValues.SetValues(vendedor);

            _context.Vendedores.Update(vendedorDB);
            await _context.SaveChangesAsync();

            return vendedorDB;
        }

        public async Task DeleteVendedorAsync(int id)
        {
            var vendedor = await _context.Vendedores.FindAsync(id);

            _context.Vendedores.Remove(vendedor);
            await _context.SaveChangesAsync();

        }

    }
}
