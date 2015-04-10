using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMyExcample
{
    class Region : Country
    {
        ArrayList node;

        public Region(string name)
            :base(name)
        {
            node = new ArrayList();
        }

        public override void Add(Country element)
        {
            node.Add(element);
        }

        public override void Remove(Country element)
        {
            node.Remove(element);
        }

        public override Country GetChild(int index)
        {
            return node[index] as Country;
        }

        public override void ShowName()
        {
            Console.WriteLine(name);

            foreach (Country el in node)
                el.ShowName();
        }
    }
}
