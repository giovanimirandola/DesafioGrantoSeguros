using DesafioGrantoSeguros.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioGrantoSeguros.Infrastructure.DataAccess.Context
{
    public class DesafioContext : DbContext
    {
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Oportunidade> Oportunidades { get; set; }

        public DesafioContext(DbContextOptions options) : base(options)
        {

        }
    }
}
