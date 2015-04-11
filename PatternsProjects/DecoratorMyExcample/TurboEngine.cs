using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMyExcample
{
    class TurboEngine : Tuning
    {
        private void Turbo()
        {
            Console.WriteLine("Turbo");
        }

        public override void Go()
        {
            base.Go();
            Turbo();
        }
    }
}
