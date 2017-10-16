using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControEntregas.Model
{
    public class Cliente
    {
        public Int64 idCliente { get; set; }
        public Token token = new Token();
    }
}
