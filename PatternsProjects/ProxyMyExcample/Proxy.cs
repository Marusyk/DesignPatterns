using System;

namespace ProxyMyExcample
{
    class Proxy : Comp
    {
        Comp comp = new Comp();

        public override void Operation()
        {
            Console.WriteLine(Name + ": working...");
            comp.Operation();
        }
    }
}
