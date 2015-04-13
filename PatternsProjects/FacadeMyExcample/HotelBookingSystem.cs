using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMyExcample
{
    class HotelBookingSystem
    {
        public int BookRoom(int roomQuality)
        {
            switch (roomQuality)
            {
                case 3:
                    return 250;
                case 4:
                    return 500;
                case 5:
                    return 900;
                default:
                    throw new ArgumentException("roomQuality should be in range [3;5]");
            }
        }
    }
}
