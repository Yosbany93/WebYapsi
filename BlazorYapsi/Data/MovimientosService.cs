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
    public class MovimientosService : IMovimientosService
    {
        private readonly HttpClient httpClient;

        public MovimientosService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Movimiento>> GetMovimientos(int Id)
        {
            var result = await httpClient.GetAsync($"movimientos/{Id}");
            string jsonString = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IList<Movimiento>>(jsonString);
        }

        public async Task<bool> PostSocio(int Id, Movimiento movimientos)
        {
            var result = await httpClient.PostAsync($"movimientos/{Id}", movimientos, new JsonMediaTypeFormatter());
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
