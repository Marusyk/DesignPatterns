using System;

namespace ObserverChangeManager
{
    class Program
    {
        static void Main()
        {
            ChangeManager manager = SimpleChangeManager.Singleton;
            // При удалении комментария со следующей строки commonObserver будет обновлен только 1 раз.
            // manager = DAGChangeManager.Singleton;

            Subject subject1 = new Subject("Subject1", manager);
            Subject subject2 = new Subject("Subject2", manager);

            Observer commonObserver = new Observer("CommonObserver");

            manager.Register(subject1, commonObserver);
            manager.Register(subject1, new Observer("Observer1"));
            manager.Register(subject1, new Observer("Observer2"));

            manager.Register(subject2, commonObserver);
            manager.Register(subject2, new Observer("Observer3"));

            subject1.Notify();

            // Delay.
            Console.ReadKey();
        }
    }
}
