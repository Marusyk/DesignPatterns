using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorMyExcample
{
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
