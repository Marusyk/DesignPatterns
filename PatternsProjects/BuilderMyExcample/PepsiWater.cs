using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMyExcample
{
    class PepsiWater : MakeSoda
    {
        Soda soda = new Soda();

        public override Soda GetSoda()
        {
            return soda;
        }

        public override void MakeBottle()
        {
            soda.BottleName = "pepsiBottle";
        }

        public override void MakeWater()
        {
            soda.SodaName = "Pepsi";
        }
    }
}
