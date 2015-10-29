using System;

namespace Mediator
{
    class Farmer : Colleague
    {
        public Farmer(Mediator mediator)
            : base(mediator)
        {
        }

        public void GrowTomato()
        {
            string tomato = "Tomato";
            Console.WriteLine(this.GetType().Name 
                + " raised " + tomato);
            mediator.Send(tomato, this);
        }
    }
}
