using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace WebPixGeo.Servico
{
    public class CorreiosServ
    {
        public static async Task<Object> GetEnderecoAsync(string cep)
        {

            RestClient client = new RestClient("https://webmaniabr.com/api/1/cep/");
            var url = cep + "/?app_key=gS4MpO1o81FWjQYyaR4fIKhGOBB9Q68V&app_secret=HtGWtH6qVrFuEpcPBX3mxLwmlu1waaC0SkpVGN9uJURC9w4j";
            RestRequest request = null;

            request = new RestRequest(url, Method.GET);
            var response = await client.ExecuteTaskAsync(request);


            Object endereco = JsonConvert.DeserializeObject<Object>(response.Content);
            return endereco;
        }
    }
}
