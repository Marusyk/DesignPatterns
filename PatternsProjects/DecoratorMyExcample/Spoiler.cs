using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMyExcample
{
    class Spoiler : Tuning
    {
        private string spoiler = "With spoiler";

        public override void Go()
        {
            base.Go();
            Console.WriteLine(spoiler);
        }
    }
}
