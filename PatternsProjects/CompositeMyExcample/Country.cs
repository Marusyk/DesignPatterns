using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMyExcample
{
    abstract class Country
    {
        protected string name;

        public Country(string name)
        {
            this.name = name;
        }

        public abstract void Add(Country element);
        public abstract void Remove(Country element);
        public abstract Country GetChild(int index);

        public abstract void ShowName();
    }
}
