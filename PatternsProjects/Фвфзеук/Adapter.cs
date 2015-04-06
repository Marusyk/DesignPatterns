using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            SpecificRequest();
        }
    }
}
