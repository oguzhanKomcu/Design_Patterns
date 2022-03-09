using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Design_Pattern
{
    public class Profile_Owner : IInformation_Profile
    {

        private string username;
        private string password;

        public Profile_Owner(string username, string password)
        {

            this.username = username;
            this.password = password;
        }


        public void ShowProfil()
        {
            Console.WriteLine($"The profile is opened and the profile content is displayed.\nUser Name: {username}");
        }
    }
}
