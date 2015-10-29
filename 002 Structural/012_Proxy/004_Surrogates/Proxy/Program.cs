using System;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            IHuman BruceWillis = new Operator();
            IHuman surrogate = new Surrogate(BruceWillis);
            surrogate.Request();
        }
    }
}
