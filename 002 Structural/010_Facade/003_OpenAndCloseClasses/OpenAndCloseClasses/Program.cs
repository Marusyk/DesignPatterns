using System;

using ClassLibrary;

namespace My
{
    class Program
    {
        static void Main()
        {
            new Facade().Method();

            // Невозможно получить доступ к закрытым классам подсистемы напрямую, минуя фасад.
            // SubsystemClassA и SubsystemClassB - закрыты.

            // Delay.
            Console.ReadKey();
        }
    }
}
