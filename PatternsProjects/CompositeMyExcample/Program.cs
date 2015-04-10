using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildCountry();
            Console.ReadKey();
        }

        public static void BuildCountry()
        {
            Country lviv = new Region("Lvivska");
            Country kyiv = new Region("Kyivska");
            Country ukraine = new Region("Ukraine");
            Country Lviv = new City("Lviv");
            Country Kyiv = new City("Kyivn");

            ukraine.Add(lviv);
            ukraine.Add(kyiv);
            lviv.Add(Lviv);
            kyiv.Add(Kyiv);
            ukraine.ShowName();
        }
    }
}
