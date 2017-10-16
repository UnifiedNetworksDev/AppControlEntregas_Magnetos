using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControEntregas.Model
{
    public class EntregasM
    {
        public string descripcionProducto { get; set; }
        public int cantidad { get; set; }

        public string cantidadString
        {
            get { return String.Format("Cantidad: {0}", this.cantidad); }
            set { cantidadString = value; } 
        }
    }
}
