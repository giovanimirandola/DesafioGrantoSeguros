using DesafioGrantoSeguros.Domain.Entities;
using DesafioGrantoSeguros.Domain.Interfaces.Repositories;
using DesafioGrantoSeguros.Domain.Interfaces.Services;
using DesafioGrantoSeguros.Domain.Validator;

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

        public IEnumerable<Vendedor> GetVendedorByRegiao(int regiao)
        {
            return _vendedorRepository.GetVendedoresByRegiao(regiao);
        }

        public int Roleta(int regiao)
        {
            var vendedor = GetVendedorByRegiao(regiao);

            return 1;
        }
    }
}
