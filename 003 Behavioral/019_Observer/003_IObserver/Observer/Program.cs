using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            // �������� ��������.
            ConcreteSubject subject = new ConcreteSubject();

            // �������� �����������.
            ConcreteObserver observer1 = new ConcreteObserver("1", subject);
            ConcreteObserver observer2 = new ConcreteObserver("2", subject);
            ConcreteObserver observer3 = new ConcreteObserver("3", subject);
            ConcreteObserver observer4 = new ConcreteObserver("4", subject);
            
            // ���������� ����������� �� �������� � ���������� ������� ��� �������.
            IDisposable unsubscriber1 = subject.Subscribe(observer1);
            IDisposable unsubscriber2 = subject.Subscribe(observer2);
            IDisposable unsubscriber3 = subject.Subscribe(observer3);
            IDisposable unsubscriber4 = subject.Subscribe(observer4);

            using (subject)
            {
                // ������� ������������ ���������� ������������ ���������.
                subject.State = null;
                subject.Notify();

                Console.WriteLine(new string('-', 70) + "1");

                // ������� ������� ���������� ����� ConcreteSubject.Unsubscriber.Dispose()
                using (unsubscriber1)
                {
                    // ������� ������������ ���������� ���������� ���������.
                    subject.State = "State 1 ...";
                    subject.Notify();
                }

                Console.WriteLine(new string('-', 70) + "2");

                // State 2 - ������� ������ ��� ���������� ������� �������� ������������.
                subject.State = "State 2 ...";
                subject.Notify();

                Console.WriteLine(new string('-', 70) + "3");

                // ������� ������� ���������� ����� ConcreteObserver.OnCompleted()
                observer2.OnCompleted();
                
                // State 3 - ������� ������ 2 ���������� ������� �������� ������������.
                subject.State = "State 3 ...";
                subject.Notify();
            } // observers.Clear()

            Console.WriteLine(new string('-', 70) + "4");

            // ������� �������� ��� ����������� ����������, �������������� �
            // ConcreteSubject.Unsubscriber.Dispose()
            observer4.OnCompleted();

            // Delay.
            Console.ReadKey();
        }
    }
}
