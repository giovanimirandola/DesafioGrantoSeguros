namespace DesafioGrantoSeguros.Domain.Entities
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Regiao Regiao { get; set; }
        public ICollection<Oportunidade> Oportunidades { get; set; }
    }
}