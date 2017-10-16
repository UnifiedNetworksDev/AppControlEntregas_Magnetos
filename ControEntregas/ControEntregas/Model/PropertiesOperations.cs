using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControEntregas.Model
{
    public class PropertiesOperations
    {
        public static void SetTokenProperties(Token token)
        {
            try
            {
                App.Current.Properties["Access_token"] = token.access_token;
                App.Current.Properties["Token_type"] = token.token_type;
                App.Current.Properties["Expires_in"] = token.expires_in;
                App.Current.Properties["UserName"] = token.userName;
                App.Current.Properties["CustomerID"] = token.customerID;
                App.Current.Properties["UserID"] = token.userID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Token GetTokenProperties()
        {
            try
            {
                Token token = new Token();
                if (App.Current.Properties.ContainsKey("Access_token"))
                    token.access_token = (string)App.Current.Properties["Access_token"];

                if (App.Current.Properties.ContainsKey("Token_type"))
                    token.token_type = (string)App.Current.Properties["Token_type"];

                if (App.Current.Properties.ContainsKey("Expires_in"))
                    token.expires_in = (Int64)App.Current.Properties["Expires_in"];

                if (App.Current.Properties.ContainsKey("UserName"))
                    token.userName = (string)App.Current.Properties["UserName"];

                if (App.Current.Properties.ContainsKey("Expires_in"))
                    token.expires_in = (Int64)App.Current.Properties["Expires_in"];

                if (App.Current.Properties.ContainsKey("UserName"))
                    token.userName = (string)App.Current.Properties["UserName"];

                if (App.Current.Properties.ContainsKey("CustomerID"))
                    token.customerID = (string)App.Current.Properties["CustomerID"];

                if (App.Current.Properties.ContainsKey("UserID"))
                    token.userID = (string)App.Current.Properties["UserID"];

                return token;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RemoveProperties()
        {
            try
            {
                if (App.Current.Properties.ContainsKey("logged"))
                    App.Current.Properties.Remove("logged");

                if (App.Current.Properties.ContainsKey("Access_token"))
                    App.Current.Properties.Remove("Access_token");

                if (App.Current.Properties.ContainsKey("Token_type"))
                    App.Current.Properties.Remove("Token_type");

                if (App.Current.Properties.ContainsKey("Expires_in"))
                    App.Current.Properties.Remove("Expires_in");

                if (App.Current.Properties.ContainsKey("UserName"))
                    App.Current.Properties.Remove("UserName");

                if (App.Current.Properties.ContainsKey("CustomerID"))
                    App.Current.Properties.Remove("CustomerID");

                if (App.Current.Properties.ContainsKey("UserID"))
                    App.Current.Properties.Remove("UserID");

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
