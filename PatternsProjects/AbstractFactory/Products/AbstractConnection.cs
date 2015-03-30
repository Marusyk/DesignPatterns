using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractConnection
    {
        public abstract string Connect(string dababaseName);
    }
}
