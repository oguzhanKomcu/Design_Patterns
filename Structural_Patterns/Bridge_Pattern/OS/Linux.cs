using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.OS
{
    public class Linux : IRun
    {
        //Now I run my browser on the desired operating system with the help of a bridge.
        public void BrowserRun()
        {
            Console.WriteLine("Running browser for Linux.");
        }
    }
}
