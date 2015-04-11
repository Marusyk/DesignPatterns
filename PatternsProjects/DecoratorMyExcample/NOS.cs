using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMyExcample
{
    class NOS : Tuning
    {
        private string nos = "N20 by NOS";

        public override void Go()
        {
            base.Go();
            Console.WriteLine(nos);
        }
    }
}
