using System;

namespace NewYear
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
