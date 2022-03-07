using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.Browser
{
    public class Mozilla : Convert
    {
        public Mozilla(IRun run) : base(run) { }

        public override void ConvertRun()
        {
            Console.WriteLine("Mozilla has been transformed.");
            base.ConvertRun();
        }
    }
}
