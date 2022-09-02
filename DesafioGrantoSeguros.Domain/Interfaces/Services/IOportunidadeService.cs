using DesafioGrantoSeguros.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrantoSeguros.Domain.Interfaces.Services
{
    public interface IOportunidadeService
    {
        Oportunidade GetAPI(Oportunidade oportunidade);
        Task<Oportunidade> GetOportunidadeAsync(int id);
        Task<IEnumerable<Oportunidade>> GetOportunidadesAsync();
        Task<Oportunidade> InsertOportunidadeAsync(Oportunidade oportunidade);
    }
}
