using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //As you can see on the application side,
            //I just called my TemplateMethod.
            //Thus, I prevented the code clutter that could occur.

            Bank_Account account1 = new Investment();
            account1.TemplateMethod(Term_Type.Mounth);

            Console.ReadLine();


        }
    }
}
