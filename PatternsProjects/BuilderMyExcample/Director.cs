using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMyExcample
{
    class Director
    {
        MakeSoda make;

        public Director(MakeSoda make)
        {
            this.make = make;
        }

        public void Create()
        {
            make.MakeBottle();
            make.MakeWater();
        }
    }
}
