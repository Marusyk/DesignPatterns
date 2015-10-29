using System;

namespace Singleton
{
    class BaseSingleton
    {
        protected static BaseSingleton uniqueInstance;

        protected BaseSingleton() { }

        public static BaseSingleton Instance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new BaseSingleton();

            return uniqueInstance;
        }
    }

    class DerivedSingleton : BaseSingleton
    {
        protected DerivedSingleton() { }

        public new static DerivedSingleton Instance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new DerivedSingleton();

            return uniqueInstance as DerivedSingleton;
        }
    }

    class Program
    {
        static void Main()
        {
            DerivedSingleton instance1 = DerivedSingleton.Instance();
            DerivedSingleton instance2 = DerivedSingleton.Instance();
            Console.WriteLine(ReferenceEquals(instance1, instance2));

            // Delay.
            Console.ReadKey();
        }
    }
}
