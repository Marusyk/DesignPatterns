using System;

// � ���������� ������ .Net ���������� �������� �������.

namespace Observer
{
    class Program
    {
        static void Main()
        {
            // ��������.
            Subject subject = new ConcreteSubject();

            // ���������, � ���������� ������ ����������.
            Observer observer = new Observer((observerState) => Console.WriteLine(observerState + " 1"));

            // �������� �� ����������� � �������.
            subject.Event += observer;
            subject.Event += (observerState) => Console.WriteLine(observerState + " 2");

            subject.State = "State ...";
            subject.Notify();

            Console.WriteLine(new string('-', 11));

            // ������� �� �����������.
            subject.Event -= observer;
            subject.Notify();

            // Delay.
            Console.ReadKey();
        }
    }
}
