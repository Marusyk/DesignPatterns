using System;

namespace ProxyMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            string site;
            IProtocol client = null;
            IProtocol proxy = new Proxy();
            do
            {
                Console.Write("Please enter site name: ");
                site = Console.ReadLine();
                if (site == "stop")
                    break;
                client = new Client(site);
                (proxy as Proxy).client = client;
                proxy.Connect();
                Console.WriteLine("You are on the '{0}'", (client as Client).GetSite);
                Console.WriteLine();

            } while (site != "stop");

            Console.WriteLine();
            Console.WriteLine("===Hisory===");
            foreach (var item in (proxy as Proxy).GetHistory())
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
