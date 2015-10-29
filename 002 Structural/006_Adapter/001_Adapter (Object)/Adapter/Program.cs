using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            Target target = new Adapter();
            target.Request();
        }
    }
}
