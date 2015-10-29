using System;
using System.ServiceModel;

// Клиент - (отправитель сообщения)

namespace Client
{
    class Client
    {
        static void Main()
        {
            Console.Title = "CLIENT";

            Uri address = new Uri("http://localhost:4000/ISubject"); 
            BasicHttpBinding binding = new BasicHttpBinding();         
            EndpointAddress endpoint = new EndpointAddress(address);

            ChannelFactory<ISubject> factory = new ChannelFactory<ISubject>(binding, endpoint);  

            // Использование factory для создания канала (или прокси - Ambassador).
            ISubject channel = factory.CreateChannel(); // channel - суть proxy.
 
            // Использование proxy для отправки сообщения предназначенного realsubject.
            channel.Say("Hello WCF!");

            // Задержка.
            Console.ReadKey();
        }
    }
}
