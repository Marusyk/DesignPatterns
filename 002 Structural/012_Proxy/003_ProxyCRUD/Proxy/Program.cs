using System;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            Subject subject = new RealSubject();
            Subject proxy;

            Console.WriteLine("Owner work:");
            proxy = new Proxy(subject, "Owner");
            TryAccess(proxy, "John");

            Console.WriteLine("Administrator work:");
            proxy = new Proxy(subject, "Administrator");
            TryAccess(proxy, "Mark");

            Console.WriteLine("Manager work:");
            proxy = new Proxy(subject, "Manager");
            TryAccess(proxy, "Lola");

            Console.WriteLine("User work:");
            proxy = new Proxy(subject, "User");
            TryAccess(proxy, "Gigi");

            // Delay.
            Console.ReadKey();
        }

        static void TryAccess(Subject proxy, string name)
        {
            try
            {
                proxy.Create(name, "TestValue");
                Console.WriteLine("Create - OK!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                proxy.Read("TestKey");
                Console.WriteLine("Read - OK!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                proxy.Update(name, "NewTestValue");
                Console.WriteLine("Update - OK!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                proxy.Delete(name);
                Console.WriteLine("Delete - OK!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(new string('-', 50));
        }
    }
}
