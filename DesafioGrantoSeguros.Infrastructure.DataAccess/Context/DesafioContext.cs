using DesafioGrantoSeguros.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioGrantoSeguros.Infrastructure.DataAccess.Context
{
    public class DesafioContext : DbContext
    {
        DbSet<Vendedor> Vendedores { get; set; }
        DbSet<Oportunidade> Oportunidades { get; set; }

        public DesafioContext(DbContextOptions options) : base(options)
        {

        }
    }
}
