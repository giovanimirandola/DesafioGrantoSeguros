using DesafioGrantoSeguros.Domain.Entities;
using DesafioGrantoSeguros.Domain.Interfaces.Repositories;
using Newtonsoft.Json;

namespace DesafioGrantoSeguros.Infrastructure.DataAccess.Repositories
{
    public class HttpRepository : IHttpRepository
    {
        private IHttpClientFactory _clientFactory;
        string url = "https://publica.cnpj.ws/cnpj";

        public HttpRepository(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<Teste?> GetResponse(Oportunidade oportunidade)
        {
            var client = _clientFactory.CreateClient();
            var response = await client.GetAsync($"{url}/{oportunidade.CNPJ}");

            if (response.IsSuccessStatusCode)
            {
                var obj = await response.Content.ReadAsStringAsync();
                Teste teste = JsonConvert.DeserializeObject<Teste>(obj);

                return teste;
            }
            else
                return null;
        }
    }
}
