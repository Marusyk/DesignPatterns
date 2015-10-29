using System;

namespace Mediator
{
    // Консервный завод.
    class Cannery : Colleague
    {
        public Cannery(Mediator mediator)
            : base(mediator)
        {
        }

        public void MakeKetchup(string message)
        {
            string ketchup = message + "Ketchup";
            Console.WriteLine(this.GetType().Name 
                + " produced " + ketchup);
            mediator.Send(ketchup, this);
        }
    }
}
