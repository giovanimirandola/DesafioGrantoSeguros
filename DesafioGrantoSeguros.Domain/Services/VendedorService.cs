using DesafioGrantoSeguros.Domain.Entities;
using DesafioGrantoSeguros.Domain.Interfaces.Repositories;
using DesafioGrantoSeguros.Domain.Interfaces.Services;

namespace DesafioGrantoSeguros.Domain.Services
{
    public class VendedorService : IVendedorService
    {
        private readonly IVendedorRepository _vendedorRepository;

        public VendedorService(IVendedorRepository vendedorRepository)
        {
            _vendedorRepository = vendedorRepository;
        }

        public async Task<Vendedor> GetVendedorAsync(int id)
        {
            return await _vendedorRepository.GetVendedorAsync(id);
        }

        public async Task<IEnumerable<Vendedor>> GetVendedoresAsync()
        {
            return await _vendedorRepository.GetVendedoresAsync();
        }

        public async Task<Vendedor> InsertVendedorAsync(Vendedor vendedor)
        {
            return await _vendedorRepository.InsertVendedorAsync(vendedor);
        }

    }
}
