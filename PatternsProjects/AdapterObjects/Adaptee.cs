using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterObjects
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("SpecificRequest");
        }
    }
}
