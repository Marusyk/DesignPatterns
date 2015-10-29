using System.Collections.Generic;

namespace RegistSingleton
{
    public class Singleton
    {
        private static Dictionary<SingletonName, Singleton> register =
            new Dictionary<SingletonName, Singleton>();

        protected static Singleton instance;

        protected Singleton() { }

        protected static void Register(SingletonName name, Singleton singleton)
        {
            register.Add(name, singleton);
        }

        protected static Singleton Lookup(SingletonName name)
        {
            return register.ContainsKey(name) ? register[name] : null;
        }

        public static Singleton Instance()
        {
            instance = Lookup(SingletonName.Simple);

            if (instance == null)
            {
                Register(SingletonName.Simple, new Singleton());
                instance = Lookup(SingletonName.Simple);
            }

            return instance;
        }
    }
}
