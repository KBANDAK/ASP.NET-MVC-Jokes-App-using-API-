using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace khaderbandak_202311342.Models
{
    public class jokeservices
    {
       
        private readonly string _baseUrl = " https://v2.jokeapi.dev/joke/Any";// api

        public async Task<joke> GetJokeAcasyc()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{_baseUrl}";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<joke>(jsonResponse);
                }
                return null;
            }
        }
    }
}