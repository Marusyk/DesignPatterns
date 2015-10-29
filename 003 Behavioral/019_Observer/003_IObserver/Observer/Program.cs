using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            // Создание издателя.
            ConcreteSubject subject = new ConcreteSubject();

            // Создание подписчиков.
            ConcreteObserver observer1 = new ConcreteObserver("1", subject);
            ConcreteObserver observer2 = new ConcreteObserver("2", subject);
            ConcreteObserver observer3 = new ConcreteObserver("3", subject);
            ConcreteObserver observer4 = new ConcreteObserver("4", subject);
            
            // Подписание подписчиков на издателя с получением объекта для отписки.
            IDisposable unsubscriber1 = subject.Subscribe(observer1);
            IDisposable unsubscriber2 = subject.Subscribe(observer2);
            IDisposable unsubscriber3 = subject.Subscribe(observer3);
            IDisposable unsubscriber4 = subject.Subscribe(observer4);

            using (subject)
            {
                // Попытка предоставить обзерверам некорректное состояние.
                subject.State = null;
                subject.Notify();

                Console.WriteLine(new string('-', 70) + "1");

                // Отписка первого подписчика через ConcreteSubject.Unsubscriber.Dispose()
                using (unsubscriber1)
                {
                    // Попытка предоставить обзерверам корректное состояние.
                    subject.State = "State 1 ...";
                    subject.Notify();
                }

                Console.WriteLine(new string('-', 70) + "2");

                // State 2 - получат только три подписчика которые остались подписанными.
                subject.State = "State 2 ...";
                subject.Notify();

                Console.WriteLine(new string('-', 70) + "3");

                // Отписка второго подписчика через ConcreteObserver.OnCompleted()
                observer2.OnCompleted();
                
                // State 3 - получат только 2 подписчика которые остались подписанными.
                subject.State = "State 3 ...";
                subject.Notify();
            } // observers.Clear()

            Console.WriteLine(new string('-', 70) + "4");

            // Попытка отписать уже отписанного подписчика, обрабатывается в
            // ConcreteSubject.Unsubscriber.Dispose()
            observer4.OnCompleted();

            // Delay.
            Console.ReadKey();
        }
    }
}
