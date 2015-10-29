using System.Threading;

namespace MutexSingleton
{
    class Singleton
    {
        private static volatile Singleton instance;
        private static Mutex mutex = new Mutex();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                Thread.Sleep(500);

                if (instance == null)
                {
                    mutex.WaitOne();

                    if (instance == null)
                        instance = new Singleton();

                    mutex.ReleaseMutex();
                }

                return instance;
            }
        }
    }
}
