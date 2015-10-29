using System;

namespace AbstractFactory
{
    class Program
    {
        public static void Main()
        {
            Client client = new Client(Factory.ConcreteFactory1);
            client.Run();

            client = new Client(Factory.ConcreteFactory2);
            client.Run();

            // Задержка.
            Console.ReadKey();
        }
    }    
}
