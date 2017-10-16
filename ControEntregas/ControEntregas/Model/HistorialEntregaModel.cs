using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControEntregas.Model
{
    public class HistorialEntregaModel
    {
        public Int64? idOrdenEntrega;
        public string idUsuario;
        public String latitud;
        public String longitud;
        public List<byte[]> firmas;
        public List<byte[]> fotos;
        [JsonIgnore]
        public Token token = new Token();

        public HistorialEntregaModel()
        {
            firmas = new List<byte[]>();
            fotos = new List<byte[]>();
        }
    }
}
