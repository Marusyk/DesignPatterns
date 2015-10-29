using System;
using System.ServiceModel;

// Сервер - (получатель сообщения).

namespace HelloWCF
{      
    class Server
    {        
        static void Main()
        {
            Console.Title = "SERVER";
          
            Uri address = new Uri("http://localhost:4000/ISubject"); 
            BasicHttpBinding binding = new BasicHttpBinding(); 
            Type contract = typeof(ISubject);           

            ServiceHost host = new ServiceHost(typeof(RealSubject));
            host.AddServiceEndpoint(contract, binding, address);
            host.Open();

            Console.WriteLine("Приложение готово к приему сообщений.");
            Console.ReadKey();

            host.Close();
        }
    }
}
