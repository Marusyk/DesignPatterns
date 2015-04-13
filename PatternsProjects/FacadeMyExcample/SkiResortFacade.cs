using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMyExcample
{
    class SkiResortFacade
    {
        private SkiRent _skiRent = new SkiRent();
        private SkiResortTicketSystem _skiResortTicketSystem = new SkiResortTicketSystem();
        private HotelBookingSystem _hotelBookingSystem = new HotelBookingSystem();

        public int HaveGoodRest(int height, int weight, int feetSize, int skierLevel, int roomQuality)
        {
            int skiPrice = _skiRent.RentSki(weight, skierLevel);
            int skiBootPrice = _skiRent.RentBoots(feetSize, skierLevel);
            int polePrice = _skiRent.RentPole(height);
            int buyDayTicket = _skiResortTicketSystem.BuyOneDayTicket();
            int hotelPrice = _hotelBookingSystem.BookRoom(roomQuality);

            return skiPrice + skiBootPrice + polePrice + buyDayTicket + hotelPrice;
        }

        public int HAveRestWithOwnSkis()
        {
            return _skiResortTicketSystem.BuyHalfDayTicket(); 
        }

    }
}
