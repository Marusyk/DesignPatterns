using System;
using System.Threading;

namespace MultithreadedSingleton
{
    class Singleton
    {
        private static volatile Singleton instance;
        private static object syncRoot = new Object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                Thread.Sleep(500);

                if (instance == null) 
                {
                    lock (syncRoot) // Закомментировать lock для проверки.
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }

                return instance;
            }
        }
    }
}
