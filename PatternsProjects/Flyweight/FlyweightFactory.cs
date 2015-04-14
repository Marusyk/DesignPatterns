using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class FlyweightFactory
    {
        Hashtable pool = new Hashtable
        {
            { "1", new ConcreteFlyweight() },
            { "2", new ConcreteFlyweight() },
            { "3", new ConcreteFlyweight() }
        };

        public Flyweight GetFlyweight(string key)
        {
            if (!pool.ContainsKey(key))
                pool.Add(key, new ConcreteFlyweight());
            return pool[key] as Flyweight;
        }
    }
}
