using System;

namespace Observer
{
    delegate void SubjectObserver();

    class Program
    {
        // Update - логически относится к подписчику (Observer).
        static void Update()
        {
            Console.WriteLine("Hello world!");
        }

        static void Main()
        {
            SubjectObserver so = new SubjectObserver(Update);

            // Аналог вызова Notify() - логически относится к издателю (Subject).
            so.Invoke(); 

            // Delay.
            Console.ReadKey();
        }
    }
}
