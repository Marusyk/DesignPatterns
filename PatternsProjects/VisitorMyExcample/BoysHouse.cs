using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorMyExcample
{
    class BoysHouse : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitBoysHouse(this);
        }

        public void TellFairyTale()
        {
            Console.WriteLine("Faity Tale...");
        }
    }
}
