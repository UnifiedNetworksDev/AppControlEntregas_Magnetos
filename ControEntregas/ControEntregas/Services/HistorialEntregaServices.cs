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
    public class HistorialEntregaServices
    {
        public async Task PostHistorialEntregas(HistorialEntregaModel data)
        {

            try
            { 
                var httpClient = new HttpClient();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Your Oauth token");
                String json = JsonConvert.SerializeObject(data);
                var content = new MultipartFormDataContent
                {
                    { new StringContent(json)}
                };

                var result = await httpClient.PostAsync(String.Format("{0}api/OrdenesEntrega/{1}/HistorialEntrega", APISettings.API_URL, data.shipperID), content).ConfigureAwait(false);
                result.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido un error al guardar la información", ex);
            }
        }
    }
}
