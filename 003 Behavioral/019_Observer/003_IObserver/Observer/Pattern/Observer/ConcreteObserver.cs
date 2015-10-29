using System;

namespace Observer
{
    class ConcreteObserver : IObserver<string>
    {
        string name;
        string observerState;
        IDisposable unsubscriber;

        public ConcreteObserver(string name, IObservable<string> subject)
        {
            this.name = name;
            unsubscriber = subject.Subscribe(this);
        }

        // Реализация интерфейса IObserver<T>

        public void OnCompleted()
        {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Observer {0}, Error: {1}", name, error.Message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Аналог Update(argument) - модель проталкивания.
        public void OnNext(string value)
        {
            observerState = value;
            Console.WriteLine("Observer {0}, State = {1}", name, observerState);
        }
    }
}
