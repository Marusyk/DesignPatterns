using System;

namespace Mediator
{
    class ConcreteMediator : Mediator
    {
        public Farmer Farmer { get; set; }
        public Cannery Cannery { get; set; }
        public Shop Shop { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Farmer)
            {
                Cannery.MakeKetchup(message);
            }
            else if (colleague == Cannery)
            {
                Shop.SellKetchup(message);
            }
        }
    }
}
