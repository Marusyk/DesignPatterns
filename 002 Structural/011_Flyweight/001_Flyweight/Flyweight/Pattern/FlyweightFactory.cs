using System.Collections;

namespace Flyweight
{
    class FlyweightFactory
    {
        Hashtable pool = new Hashtable();

        public Flyweight GetConcreteFlyweight(string key)
        {
            if (!pool.ContainsKey(key))
                pool.Add(key, new ConcreteFlyweight());

            return pool[key] as Flyweight;
        }

        public Flyweight GetUnsharedConcreteFlyweight()
        {
            return new UnsharedConcreteFlyweight();
        }
    }
}
