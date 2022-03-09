using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProfilProxy proxy1 = new ProfilProxy("Therec", "123");

            proxy1.ShowProfil();
            Console.ReadKey();
        }
    }
}
