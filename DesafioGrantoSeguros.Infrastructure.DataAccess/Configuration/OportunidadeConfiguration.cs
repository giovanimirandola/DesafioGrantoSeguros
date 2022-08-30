using DesafioGrantoSeguros.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrantoSeguros.Infrastructure.DataAccess.Configuration
{
    public class OportunidadeConfiguration : IEntityTypeConfiguration<Oportunidade>
    {
        public void Configure(EntityTypeBuilder<Oportunidade> builder)
        {

        }
    }
}
