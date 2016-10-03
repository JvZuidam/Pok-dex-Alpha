using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Net.Http;

namespace Pokèdex_Alpha.Classes
{
    public class SendData
    {
        //Clarify the register items
        public string RegName;
        public string RegUsername;
        public string RegPass;
        public string RegPassRpt;
        public string RegEmail;
        public string RegHash;

        //Clarify the login items
        public string LogName;
        public string LogPass;
        public string LogHash;

        public async void SendRegister()
        {
            using (var client = new HttpClient())
            {
                //Create a new dictionary
                var _regdata = new Dictionary<string, string>();

                //Add the register form items to it
                _regdata.Add("name", RegName);
                _regdata.Add("username", RegUsername);
                _regdata.Add("email", RegEmail);
                _regdata.Add("Hash", RegHash);
             

                var content = new FormUrlEncodedContent(_regdata);

                var response = await client.PostAsync("http://henkgrol.hol.es/Register.php", content);

                var responseString = await response.Content.ReadAsStringAsync();
            }
            
        }

        public void SendLogin()
        {
            var _logdata = new Dictionary<string, object>();

            //Add the register form items to it
            _logdata.Add("name", LogName);
            _logdata.Add("pass", LogName);

        }
    }
}
