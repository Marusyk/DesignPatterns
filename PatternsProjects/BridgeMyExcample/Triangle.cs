using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMyExcample
{
    class Triangle : Shape
    {
        public override void Draw(string color)
        {
            base.Draw(color);

            Console.WriteLine("Triangle");
        }
    }
}
