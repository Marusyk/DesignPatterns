using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMyExcample
{
    abstract class MakeSoda
    {
        public abstract Soda GetSoda();
        public abstract void MakeBottle();
        public abstract void MakeWater();
    }
}
