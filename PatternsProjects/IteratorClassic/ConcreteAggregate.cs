using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorClassic
{
    class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override object this[int index]
        {
            get
            {
                return items[index];
            }

            set
            {
                items.Insert(index, value);
            }
        }
    }
}
