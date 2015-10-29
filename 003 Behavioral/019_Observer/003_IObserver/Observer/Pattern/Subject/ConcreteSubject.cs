using System;
using System.Collections.Generic;

namespace Observer
{
    class ConcreteSubject : IObservable<string>, IDisposable
    {
        public string State { get; set; }

        List<IObserver<string>> observers = new List<IObserver<string>>();

        public void Notify()
        {
            foreach (IObserver<string> observer in observers)
            {
                if (this.State == null)
                    observer.OnError(new NullReferenceException());
                else
                    observer.OnNext(this.State); // ������ �������������.
            }
        }

        // ���������� ���������� IObservable<T> (UnSubscribe ����������� ����� IDisposable)

        /// <summary>
        /// ��������� ����������.
        /// </summary>
        /// <param name="observer">���������� ���������</param>
        /// <returns>������ ������������ ������������ ����������</returns>
        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }

        /// <summary>
        /// �������� ���� �����������.
        /// </summary>
        public void Dispose()
        {
            observers.Clear();
        }

        // Nested Class
        class Unsubscriber : IDisposable
        {
            List<IObserver<string>> observers;
            IObserver<string> observer;

            public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                if (observers.Contains(observer))
                    observers.Remove(observer);
                else
                    observer.OnError(new Exception("������ ��������� �� �������� �� ��������."));
            }
        }
    }
}
