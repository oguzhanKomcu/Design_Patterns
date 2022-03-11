using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Design_Pattern
{
    public class Opening : ICommand
    {
        // Concrete Command Class

        public void Execute()
        {
            Console.WriteLine("The file is opening.");
        }
    }
}
