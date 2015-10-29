using System;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            var mediator = new ConcreteMediator();
            var farmer = new Farmer(mediator);
            var cannery = new Cannery(mediator);
            var shop = new Shop(mediator);

            mediator.Farmer = farmer;
            mediator.Cannery = cannery;
            mediator.Shop = shop;

            farmer.GrowTomato();
            
            // Delay.
            Console.ReadKey();
        }
    }
}
