using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMyExcample
{
    class SkiRent
    {
        public int RentBoots(int feetSize, int skierLevel)
        {
            return 20;
        }

        public int RentPole(int height)
        {
            return 5;
        }

        public int RentSki(int weight, int skierLevel)
        {
            return 40;
        }
    }
}
