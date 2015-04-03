using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();
            Console.WriteLine(ReferenceEquals(instance1, instance2));

            instance1.SingletonOperation();
            string singletonData = instance1.GetSingletonData();
            Console.WriteLine(singletonData);
            Console.ReadKey();
        }
    }

    class Singleton
    {
        static Singleton uniqueInstance;
        string singletonData = string.Empty;

        protected Singleton () { }

        public static Singleton Instance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Singleton();
            return uniqueInstance;
        }

        public string GetSingletonData()
        {
            return singletonData;
        }

        public void SingletonOperation()
        {
            singletonData = "SingeltonData";
        }
    }
}
