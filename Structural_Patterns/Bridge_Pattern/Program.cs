using Bridge_Pattern.Browser;
using Bridge_Pattern.OS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Convert convertWindows = new GoogleChrome(new Linux());
            convertWindows.ConvertRun();
            

            Console.ReadKey();

        }
    }
}
