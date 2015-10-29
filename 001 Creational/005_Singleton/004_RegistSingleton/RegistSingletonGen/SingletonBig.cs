using System;
using System.Collections.Generic;

namespace RegistSingleton
{
    class SingletonBig : Singleton
    {
        protected SingletonBig() { }

        public static new SingletonBig Instance()
        {
            try
            {
                return Lookup<SingletonBig>();
            }
            catch (KeyNotFoundException)
            {
                Register(new SingletonBig());
                return Lookup<SingletonBig>();
            }
        }
    }
}
