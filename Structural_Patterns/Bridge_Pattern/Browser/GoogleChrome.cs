using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.Browser
{
    public class GoogleChrome : Convert
    {
        //Objects cannot be produced from abstract classes, but I throw my object that comes to my parent class with the keyword "base".
        public GoogleChrome(IRun run) : base(run) { }

        //I convert my browser to the desired OS by applying our method. Then I run my "ConvertRun" method in my ancestor class.
        public override void ConvertRun()
        {
            Console.WriteLine("Google Chrome has been transformed.");
            base.ConvertRun();
        }
    }
}
