using System;
using System.Collections.Generic;

namespace BasicAuthenticationa
{    
    public class BasicAuthentication
    {       
        public bool OnAuthorization(string Authorization) 
        {
            string authToken = Authorization.Remove(0, 6);
            string decoding = DecodeAuth(authToken);

            if (authorizedUsers.Contains(decoding))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string DecodeAuth(string authToken)
        {                        
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
        }

        private List<string> authorizedUsers = new List<string>
        {
            "admin:admin",
            "test:123",
            "alex:alex2020"
        };
    }
}
