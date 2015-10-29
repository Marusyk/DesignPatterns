using System;
using System.Collections.Generic;

namespace MultiSingleton
{
    public class Singleton
    {
        static List<Singleton> singletons;
        public int ID { get; private set; }
        static int position = -1;

        protected Singleton(int id)
        {
            ID = id;
        }

        public static int SetLimit
        {
            get { return singletons.Count; }
            set
            {
                singletons = new List<Singleton>();

                for (int i = 0; i < value; i++)
                {
                    singletons.Add(new Singleton(i));
                }
            }
        }

        public static Singleton Instance()
        {
            if (singletons == null)
                SetLimit = 1;

            if (position < singletons.Count - 1)
                position++;
            else
                position = 0;

            return singletons[position];
        }
    }

    class Program
    {
        static void Main()
        {
            Singleton[] singletons = new Singleton[10];

            Singleton.SetLimit = 5;

            for (int i = 0; i < 10; i++)
                singletons[i] = Singleton.Instance();

            for (int i = 0; i < 10; i++)
                Console.WriteLine(singletons[i].ID);

            // Delay.
            Console.ReadKey();
        }
    }
}
