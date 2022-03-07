using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.Browser
{
    public class Opera : Convert
    {
        public Opera(IRun run) : base(run) { }

        public override void ConvertRun()
        {
            Console.WriteLine("Opera has been transformed.");
            base.ConvertRun();
        }




    }
}
