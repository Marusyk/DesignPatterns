using System;

namespace ComedyFilm
{
    class Program
    {
        static void Main()
        {
            ActorMikeMyers mike = new ActorMikeMyers();

            RoleAustinPowers austin = new RoleAustinPowers(mike);
            austin.Greeting("Hello! I'm Austin Powers!");

            RoleDoctorEvil dr = new RoleDoctorEvil(mike);
            dr.Greeting("Hello! I'm Dr.Evil!");

            // Delay.
            Console.ReadKey();
        }
    }
}
