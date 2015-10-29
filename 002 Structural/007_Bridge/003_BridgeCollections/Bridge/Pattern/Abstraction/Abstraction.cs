using System;
using System.Collections;

namespace Bridge
{
    abstract class Abstraction
    {
        public IDictionary Implementor { get; protected set; }

        public void Add(object key, object value)
        {
            Implementor.Add(key, value);
        }

        public object this[object key]
        {
            get { return Implementor[key]; }
        }

        public int Count
        {
            get { return Implementor.Count; }
        }
    }
}
