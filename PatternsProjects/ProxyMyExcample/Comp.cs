using System;

namespace ProxyMyExcample
{
    class Comp
    {
        public string Name { get; set; }

        public virtual void Operation()
        {
            Console.WriteLine("Connect...");
        }
    }
}
