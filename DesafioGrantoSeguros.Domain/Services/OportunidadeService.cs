using DesafioGrantoSeguros.Domain.Entities;
using DesafioGrantoSeguros.Domain.Interfaces.Repositories;
using DesafioGrantoSeguros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrantoSeguros.Domain.Services
{
    public class OportunidadeService : IOportunidadeService
    {
        private readonly IOportunidadeRepository _oportunidadeRepository;
        private readonly IHttpRepository _httpRepository;
        private readonly IVendedorService _vendedorService;

        private string baseUrl = "https://publica.cnpj.ws/cnpj/";

        public OportunidadeService(IOportunidadeRepository oportunidadeRepository, IHttpRepository httpRepository, IVendedorService vendedorService)
        {
            _oportunidadeRepository = oportunidadeRepository;
            _httpRepository = httpRepository;
            _vendedorService = vendedorService;
        }

        public Oportunidade GetAPI(Oportunidade oportunidade)
        {
            var response = _httpRepository.GetResponse(oportunidade);

            if (response != null)
            {
                oportunidade.RazaoSocial = response.razao_social;
                oportunidade.Descricao = response.estabelecimento.atividade_principal.descricao;
                oportunidade.VendedorId = _vendedorService.Roleta(response.estabelecimento.estado.ibge_id);
            }

            return null;
        }

        public Task<Oportunidade> GetOportunidadeAsync(int id)
        {
            return _oportunidadeRepository.GetOportunidadeAsync(id);
        }

        public Task<IEnumerable<Oportunidade>> GetOportunidadesAsync()
        {
            return _oportunidadeRepository.GetOportunidadesAsync();
        }

        public Task<Oportunidade> InsertOportunidadeAsync(Oportunidade oportunidade)
        {
            return _oportunidadeRepository.InsertOportunidadeAsync(oportunidade);
        }
    }
}
