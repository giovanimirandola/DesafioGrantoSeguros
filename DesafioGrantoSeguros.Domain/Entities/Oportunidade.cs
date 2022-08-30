using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrantoSeguros.Domain.Entities
{
    public class Oportunidade
    {   
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public float ValorMonetario { get; set; }
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
