using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConctereObserver(subject));
            subject.Attach(new ConctereObserver(subject));
            subject.State = "Some State...";
            subject.Notify();

            Console.ReadKey();
        }
    }
}
