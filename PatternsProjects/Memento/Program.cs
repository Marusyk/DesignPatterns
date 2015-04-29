using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "On";
            Console.WriteLine("State of originator " + originator.State);

            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            originator.State = "Of";
            Console.WriteLine("State of originator " + originator.State);

            originator.SetMemento(caretaker.Memento);
            Console.WriteLine("State of originator " + originator.State);

            Console.ReadKey();
        }
    }
}
