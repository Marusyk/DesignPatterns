using System;
using System.Collections.Generic;

namespace RegistSingleton
{
    public class Singleton
    {
        private static Dictionary<Type, Singleton> register =
            new Dictionary<Type, Singleton>();

        protected Singleton() { }

        protected static void Register(Singleton singleton)
        {
            register.Add(singleton.GetType(), singleton);
        }

        protected static dynamic Lookup<T>()
        {
            return register[typeof(T)];
        }

        public static Singleton Instance()
        {
            try
            {
                return Lookup<Singleton>();
            }
            catch (KeyNotFoundException)
            {
                Register(new Singleton());
                return Lookup<Singleton>();
            }
        }
    }
}
