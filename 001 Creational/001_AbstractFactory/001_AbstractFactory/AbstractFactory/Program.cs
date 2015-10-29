using System;

namespace AbstractFactory
{
    class Program
    {
        public static void Main()
        {
            Client client = null;

            client = new Client(new ConcreteFactory1());
            client.Run();

            client = new Client(new ConcreteFactory2());
            client.Run();
        }
    }    
}
