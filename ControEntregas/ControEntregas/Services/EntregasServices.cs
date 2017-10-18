using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControEntregas.Model;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using Xamarin.Forms;
using System.Net.Http.Headers;

namespace ControEntregas.Services
{
    public class EntregasServices
    {
        public async Task<List<EntregasM>> GetEntregasAsync(string shipperID)
        {
            try
            {
                var httpClient = new HttpClient();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Your Oauth token");
                var json = await httpClient.GetStringAsync(String.Format("{0}/api/Clientes/1/OrdenesEntrega/{1}", APISettings.API_URL, shipperID)).ConfigureAwait(false);
                var taskModels = JsonConvert.DeserializeObject<List<EntregasM>>(json);
                return taskModels;
            }
            catch (HttpRequestException ex)
            {
                if (ex.Message == "404 (Not Found)")
                {
                    throw new Exception("No fueron encontrados artículos relacionados a esta orden de entrega", ex);
                }
                else
                {
                    throw new Exception("Ha ocurrido un error al consultar los datos", ex);
                }
            }
        }
    }
}