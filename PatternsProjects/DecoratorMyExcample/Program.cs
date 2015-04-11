using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Mers = new Mercedes();
            Car BMW = new BMW();
            Tuning N20 = new NOS();
            Tuning Turbo = new TurboEngine();
            Tuning Spoiler = new Spoiler();

            //Decore Mers
            Turbo.carModel = Mers;
            Spoiler.carModel = Turbo;
            Spoiler.Go();

            //Decore BMW
            Turbo.carModel = BMW;
            N20.carModel = Turbo;
            N20.Go();

            Console.ReadKey();
        }
    }
}
