using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject");
        }
    }
}
