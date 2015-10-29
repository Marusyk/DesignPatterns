using System;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            Subject subject = new Proxy();
            subject.Request();
        }
    }
}
