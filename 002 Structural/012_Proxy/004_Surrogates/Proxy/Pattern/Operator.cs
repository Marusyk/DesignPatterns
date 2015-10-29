using System;

namespace Proxy
{
    class Operator : IHuman
    {
        public void Request()
        {
            Console.WriteLine("Operator");
        }
    }
}
