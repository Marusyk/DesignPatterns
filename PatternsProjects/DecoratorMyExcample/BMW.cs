using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMyExcample
{
    class BMW : Car
    {
        public override void Go()
        {
            Console.WriteLine("I'm BMW baby");
        }
    }
}
