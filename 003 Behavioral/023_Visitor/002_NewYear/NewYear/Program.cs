using System;

namespace NewYear
{
    class Program
    {
        static void Main()
        {
            Village village = new Village();
            village.Add(new BoysHouse());
            village.Add(new GirlsHouse());

            village.Accept(new Santa());

            // Delay.
            Console.ReadKey();
        }
    }
}
