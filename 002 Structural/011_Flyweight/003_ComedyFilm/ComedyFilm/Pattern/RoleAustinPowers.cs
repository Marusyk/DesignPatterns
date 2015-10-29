using System;

namespace ComedyFilm
{
    // Неразделяемый.
    class RoleAustinPowers : Flyweight
    {
        Flyweight flyweight;

        public RoleAustinPowers(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            this.flyweight.Greeting(speech);
        }
    }
}
