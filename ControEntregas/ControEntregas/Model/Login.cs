using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControEntregas.Model
{
    public class Login
    {
        public string userName { get; set; }
        public string password { get; set; } 

        public string grant_type { get; set; }

        public Login(string name, string pasword)
        {
            this.userName = name;
            this.password = pasword;
            this.grant_type = "password";
        }
    }

}
