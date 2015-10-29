using System;

// Сервис.

namespace HelloWCF
{
    class RealSubject : ISubject
    {
        public void Say(string input)
        {
            Console.WriteLine("Сообщение: {0} - получено. ", input);
        }
    }
}
