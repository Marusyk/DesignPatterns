using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMyExcample
{
    class City : Country
    {
        public City(string name)
            :base(name)
        { }

        public override void Add(Country element)
        {
            throw new InvalidOperationException();
        }

        public override Country GetChild(int index)
        {
            throw new InvalidOperationException();
        }

        public override void Remove(Country element)
        {
            throw new InvalidOperationException();
        }

        public override void ShowName()
        {
            Console.WriteLine(name);
        }
    }
}
