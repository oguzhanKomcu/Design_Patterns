using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            InvokerFileOperations  ınvoker = new InvokerFileOperations();
            ınvoker.AddCommand(new Opening());
            ınvoker.AddCommand(new Save());
            ınvoker.AddCommand(new Closing());

            ınvoker.ExecuteAll();   


            Console.ReadLine();
        }
    }
}
