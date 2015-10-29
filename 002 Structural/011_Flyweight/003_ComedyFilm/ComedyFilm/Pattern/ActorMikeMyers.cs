using System;

namespace ComedyFilm
{
    // Разделяемый.
    class ActorMikeMyers : Flyweight
    {
        public override void Greeting(string speech)
        {
            Console.WriteLine(speech);
        }
    }
}
