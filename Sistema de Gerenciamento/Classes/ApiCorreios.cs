using Newtonsoft.Json;
using Sistema_de_Gerenciamento.Classes.QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class ApiCorreios
    {
        private DadosCEP temperatures = new DadosCEP();

        public async Task APICorreios(string _cep)
        {
            HttpClient cliente = new HttpClient { BaseAddress = new Uri($"https://viacep.com.br/ws/{_cep}/json/") };
            var response = await cliente.GetAsync(string.Empty);
            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<DadosCEP>(content);

            temperatures = users;
        }

        public DadosCEP RetornoApi()
        {
            return temperatures;
        }
    }
}