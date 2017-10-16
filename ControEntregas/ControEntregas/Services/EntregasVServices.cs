using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControEntregas.Model;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ControEntregas.Services
{
    public class EntregasVServices
    {
        public async Task<List<EntregasModel>> Get(Int64 idCliente)
        {
            try
            {
                var httpClient = new HttpClient();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Your Oauth token");
                var json = await httpClient.GetStringAsync(String.Format("{0}/api/Clientes/{1}/OrdenesEntrega", APISettings.API_URL, idCliente)).ConfigureAwait(false);
                var taskModels = JsonConvert.DeserializeObject<List<EntregasModel>>(json);
                return taskModels;
            }
            catch (HttpRequestException ex)
            {
                if (ex.Message == "404 (Not Found)")
                {
                    throw new Exception("No fueron encontradas órdenes de entrega", ex);
                }
                else
                {
                    throw new Exception("Ha ocurrido un error al consultar los datos", ex);
                }
            }
        }
    }
}
