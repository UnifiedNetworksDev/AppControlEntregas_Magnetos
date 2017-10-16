using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControEntregas.Model;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace ControEntregas.Services
{
    public class UserServices
    {
        public async Task<Token> PostUserAsync(Login data)
        {
            try
            {
                var httpClient = new HttpClient();
                var httpContent = new FormUrlEncodedContent(new[]
                 {
                    new KeyValuePair<string,string>("userName",data.userName),
                    new KeyValuePair<string,string>("password",data.password),
                    new KeyValuePair<string,string>("grant_type", data.grant_type)
                });
                var result = await httpClient.PostAsync(String.Format("{0}token", APISettings.API_URL), httpContent).ConfigureAwait(false);
                if(result.StatusCode == HttpStatusCode.BadRequest)
                {
                    throw new WebException("Usuario o contraseña incorrectos");
                }

                string json = await result.Content.ReadAsStringAsync();
                Token token = JsonConvert.DeserializeObject<Token>(json);
                return token;
            }
            catch (WebException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido un error al consultar los datos", ex);
            }
        }
    }
}
