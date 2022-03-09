using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Design_Pattern
{
    public class ProfilProxy : IInformation_Profile
    {
        //With this design pattern, we will prevent code duplication.
        //We will take the load of the class by reaching the class that needs to be reached from the "proxy" I created.
        //In this way, we also provide an increase in performance.
        //



        private Profile_Owner _owner;
        private string username;
        private string password;

        public ProfilProxy(string username, string password)
        {

            this.username = username;
            this.password = password;
        }

        //If the object is created here, I prevent it from being created again...

        public void ShowProfil()
        {
            if (_owner == null)
            {
                _owner = new Profile_Owner(username, password);
            }
            _owner.ShowProfil();
        }




    }
}
