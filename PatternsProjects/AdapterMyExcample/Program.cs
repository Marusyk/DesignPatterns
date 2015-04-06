using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMyExcample
{
    class ElectricityCustomer
    {
        public static void ChargeNotebook(INewElectricitySystem electricitySystem)
        {
            Console.WriteLine(electricitySystem.MatchWideSocket());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var newElectricitySystem = new NewElectricitySystem();
            ElectricityCustomer.ChargeNotebook(newElectricitySystem);

            var oldElectricitySystem = new OldElectricitySystem();
            var adapter = new Adapter(oldElectricitySystem);
            ElectricityCustomer.ChargeNotebook(adapter);

            Console.ReadKey();
        }
    }
}
