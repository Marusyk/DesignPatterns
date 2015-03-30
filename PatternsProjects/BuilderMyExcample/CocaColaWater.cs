using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMyExcample
{
    class CocaColaWater : MakeSoda
    {
        Soda soda = new Soda();
        public override Soda GetSoda()
        {
            return soda;
        }

        public override void MakeBottle()
        {
            soda.BottleName = "cocaColaBottle";
        }

        public override void MakeWater()
        {
            soda.SodaName = "CocaCola";
        }
    }
}
