using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControEntregas.Model
{
    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public Int64 expires_in;
        public string userName { get; set; }
        public string customerID { get; set; }
        public string userID { get; set; }

    }
}
