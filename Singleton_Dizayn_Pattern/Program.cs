using Singleton_Dizayn_Pattern.LAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Now I can't constantly call and use my class. I create it once and use it continuously when I need it. Thus, I get rid of the load that will take up space and affect the performance.


            //I accessed my static "Instance" method by calling my class and assigned it to my variable named "test". Now I have created an object.
            var test = MusicPlayer.Instance();

            //Here, I accessed and used my method in my created object..
            Console.WriteLine($"{ test.Player()}");
            Console.ReadKey();


        }
    }
}
