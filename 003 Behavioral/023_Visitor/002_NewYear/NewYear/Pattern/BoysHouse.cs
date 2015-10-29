using System;

namespace NewYear
{
    class BoysHouse : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitBoysHouse(this);
        }

        public void TellFairyTale()
        {
            Console.WriteLine("Fairy Tale....");
        }
    }
}
