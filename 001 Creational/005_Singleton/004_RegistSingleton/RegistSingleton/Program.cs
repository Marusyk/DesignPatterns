using System;

namespace RegistSingleton
{
    class Program
    {
        static void Check(object o1, object o2)
        {
            Console.WriteLine(o1.GetType().Name);
            Console.WriteLine(o1.GetHashCode() + " = " + o2.GetHashCode() + "\n");
        }

        static void Main()
        {
            Singleton simple1 = Singleton.Instance();
            Singleton simple2 = Singleton.Instance();
            Check(simple1, simple2);

            SingletonBig big1 = SingletonBig.Instance();
            SingletonBig big2 = SingletonBig.Instance();
            Check(big1, big2);

            SingletonSmall small1 = SingletonSmall.Instance();
            SingletonSmall small2 = SingletonSmall.Instance();
            Check(small1, small2);

            // Delay.
            Console.ReadKey();
        }
    }
}
