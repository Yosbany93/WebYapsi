using BlazorYapsi.Data.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace BlazorYapsi.Data
{
    public class SociosService : ISociosService
    {
        private readonly HttpClient httpClient;

        public SociosService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<bool> DeleteSocio(int Id)
        {
            var result = await httpClient.DeleteAsync($"socios/{Id}");
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> FormSocio(int Id, Socio socio)
        {
            var result = await httpClient.PutAsync($"socios/{Id}", socio,  new JsonMediaTypeFormatter());
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<IEnumerable<Socio>> GetSociosAsync()
        {
            var result = await httpClient.GetAsync("socios");
            string jsonString = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IList<Socio>>(jsonString);
        }

        public async Task<bool> PostSocio(Socio socio)
        {
            var result = await httpClient.PostAsync("socios", socio, new JsonMediaTypeFormatter());
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
