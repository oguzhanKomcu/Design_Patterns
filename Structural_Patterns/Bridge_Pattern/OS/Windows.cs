using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.OS
{
    public class Windows : IRun
    {
        public void BrowserRun()
        {
            Console.WriteLine("Running browser for Windows.");
        }



    }
}
