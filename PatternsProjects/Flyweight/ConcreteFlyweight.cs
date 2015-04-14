using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class ConcreteFlyweight : Flyweight
    {
        int intrinsicState;

        public override void Operation(int extrinsicState)
        {
            intrinsicState = extrinsicState;
        }
    }
}
