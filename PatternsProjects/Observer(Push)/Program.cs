using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Push_
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject));
            subject.Attach(new ConcreteObserver(subject));
            subject.State = "Some State...";
            subject.Notify();

            Console.ReadKey();
        }
    }
}
