using System;

namespace LazySingleton
{
    class Singleton
    {
        static Lazy<Singleton> instance = new Lazy<Singleton>();

        public static Singleton Instance
        {
            get
            {
                return instance.Value;
            }
        }
    }
}
