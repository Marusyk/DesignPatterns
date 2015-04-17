using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 2)
                Console.WriteLine("Two");
            else if (Successor != null)
                Successor.HandleRequest(request);
        }
    }
}
