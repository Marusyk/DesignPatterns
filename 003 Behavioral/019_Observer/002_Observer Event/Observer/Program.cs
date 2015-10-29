using System;

// В событийной модели .Net обзервером является делегат.

namespace Observer
{
    class Program
    {
        static void Main()
        {
            // Издатель.
            Subject subject = new ConcreteSubject();

            // Подписчик, с сообщенным лямбда выражением.
            Observer observer = new Observer((observerState) => Console.WriteLine(observerState + " 1"));

            // Подписка на уведомление о событии.
            subject.Event += observer;
            subject.Event += (observerState) => Console.WriteLine(observerState + " 2");

            subject.State = "State ...";
            subject.Notify();

            Console.WriteLine(new string('-', 11));

            // Отписка от уведомлений.
            subject.Event -= observer;
            subject.Notify();

            // Delay.
            Console.ReadKey();
        }
    }
}
