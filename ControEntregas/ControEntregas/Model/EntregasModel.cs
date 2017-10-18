using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControEntregas.Model
{
    public class EntregasModel
    {
        public Int64 idOrdenEntrega { get; set; }
        public string descripcion { get; set; }
        public string shipperID { get; set; }
        public Token token = new Token();
    }
}