using System;
using System.Collections.Generic;

// Service Locator (Локатор Сервиса)


namespace ServiceLocator_1
{
    class Program
    {
        static void Main()
        {
            IServiceLocator serviceLocator = new ServiceLocator();

            IServiceA serviceA = serviceLocator.GetService<IServiceA>();
            IServiceB serviceB = serviceLocator.GetService<IServiceB>();
            IServiceC serviceC = serviceLocator.GetService<IServiceC>();

            // Задержка.
            Console.ReadKey();
        }
    }
}
