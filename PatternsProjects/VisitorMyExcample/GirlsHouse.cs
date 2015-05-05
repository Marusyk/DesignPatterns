using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorMyExcample
{
    class GirlsHouse : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitGirlsHouse(this);
        }

        public void GiveDress()
        {
            Console.WriteLine("Dress as a gift.");
        }
    }
}
