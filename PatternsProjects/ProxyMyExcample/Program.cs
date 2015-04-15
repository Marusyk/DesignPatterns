using System;

namespace ProxyMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            Comp proxy = new Proxy();
            proxy.Name = "Proxy";
            proxy.Operation();

            Console.ReadKey();
        }
    }
}
