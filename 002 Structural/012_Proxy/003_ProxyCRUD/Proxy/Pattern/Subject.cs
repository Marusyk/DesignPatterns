using System;

namespace Proxy
{
    abstract class Subject
    {
        public abstract void Create(string key, string value);
        public abstract string Read(string key);
        public abstract bool Update(string key, string value);
        public abstract bool Delete(string key);
    }
}
