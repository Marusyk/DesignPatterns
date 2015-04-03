using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton[] singletons = new Singleton[10];

            for (int i = 0; i < 10; i++)
                singletons[i] = Singleton.Instance();

            for (int i = 0; i < 10; i++)
                Console.WriteLine(singletons[i].ID);

            // Delay.
            Console.ReadKey();
        }
    }
    public class Singleton
    {
        static Singleton first;
        static Singleton second;
        static bool flag;
        public int ID { get; private set; }

        protected Singleton(int id)
        {
            ID = id;
        }

        public static Singleton Instance()
        {
            if (first == null)
            {
                first = new Singleton(1);
                return first;
            }
            else if (second == null)
            {
                second = new Singleton(2);
                return second;
            }

            if (!flag)
            {
                flag = true;
                return first;
            }
            else
            {
                flag = false;
                return second;
            }
        }
    }
}
