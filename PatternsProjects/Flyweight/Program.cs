using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicState = 0;

            Flyweight flyweight = null;
            FlyweightFactory factory = new FlyweightFactory();

            flyweight = factory.GetFlyweight("1");
            flyweight.Operation(extrinsicState);

            flyweight = factory.GetFlyweight("10");
            flyweight.Operation(extrinsicState);

            flyweight = new UnsharedConcreteFlyweight();
            flyweight.Operation(extrinsicState);

            Console.ReadKey();
        }
    }
}
