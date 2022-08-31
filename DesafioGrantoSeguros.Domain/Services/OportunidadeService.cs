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

        public OportunidadeService(IOportunidadeRepository oportunidadeRepository)
        {
            _oportunidadeRepository = oportunidadeRepository;
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
