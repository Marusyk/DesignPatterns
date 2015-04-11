using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMyExcample
{
    abstract class Tuning : Car
    {
        public Car carModel { protected get; set; }
        public override void Go()
        {
            if (carModel != null)
                carModel.Go();
        }
    }
}
