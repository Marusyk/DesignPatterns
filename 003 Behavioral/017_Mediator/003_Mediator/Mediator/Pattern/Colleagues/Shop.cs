using System;

namespace Mediator
{
    class Shop : Colleague
    {
         public Shop(Mediator mediator)
            : base(mediator)
        {
        }
               
        public void SellKetchup(string message)
        {
            Console.WriteLine(this.GetType().Name 
                + " sold " + message);
        }
    }
}
