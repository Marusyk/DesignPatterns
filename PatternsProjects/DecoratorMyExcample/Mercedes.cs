using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMyExcample
{
    class Mercedes : Car
    {
        public override void Go()
        {
            Console.WriteLine("This is the Mercedes. And he is going now.");
        }
    }
}
