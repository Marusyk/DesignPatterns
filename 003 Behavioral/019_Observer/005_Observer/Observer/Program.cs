using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            ConcreteSubject aConcreteSubject = new ConcreteSubject();
            ConcreteObserver aConcreteObserver = new ConcreteObserver(aConcreteSubject);
            ConcreteObserver anotherConcreteObserver = new ConcreteObserver(aConcreteSubject);

            aConcreteSubject.aConcreteObserver = aConcreteObserver;
            aConcreteSubject.anotherConcreteObserver = anotherConcreteObserver;

            aConcreteObserver.ChangeState("First state!");

            Console.WriteLine(new string('-', 70));

            anotherConcreteObserver.ChangeState("Second state!");
        }
    }
}
