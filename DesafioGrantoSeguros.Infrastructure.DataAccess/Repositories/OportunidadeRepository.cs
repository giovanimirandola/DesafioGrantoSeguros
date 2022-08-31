using DesafioGrantoSeguros.Domain.Entities;
using DesafioGrantoSeguros.Domain.Interfaces.Repositories;
using DesafioGrantoSeguros.Infrastructure.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrantoSeguros.Infrastructure.DataAccess.Repositories
{
    public class OportunidadeRepository : IOportunidadeRepository
    {
        private readonly DesafioContext _context;

        public OportunidadeRepository(DesafioContext context)
        {
            _context = context;
        }

        public async Task<Oportunidade> GetOportunidadeAsync(int id)
        {
            return await _context.Oportunidades.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<IEnumerable<Oportunidade>> GetOportunidadesAsync()
        {
            return await _context.Oportunidades.AsNoTracking().ToListAsync();
        }

        public async Task<Oportunidade> InsertOportunidadeAsync(Oportunidade oportunidade)
        {
            await _context.Oportunidades.AddAsync(oportunidade);
            await _context.SaveChangesAsync();

            return oportunidade;
        }
    }
}
