using System.Collections;
using System.Collections.Generic;

namespace InternalIterator
{
    class Enumerable
    {
        List<double> list = new List<double> { 1, 2, 3, 4 };

        public IEnumerable Transform(Function function)
        {
            return new Enumerator
            {
                Enumerable = this,
                Function = function
            };
        }

        // Внутренний (пассивный) итератор.
        class Enumerator : IEnumerable, IEnumerator
        {
            public Enumerable Enumerable { get; set; }
            public Function Function { get; set; }
            object current;
            int position = -1;

            bool IEnumerator.MoveNext()
            {
                if (position < Enumerable.list.Count - 1)
                {
                    position++;
                    current = Function(Enumerable.list[position]);
                    return true;
                }

                return false;
            }

            void IEnumerator.Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get { return current; }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this;
            }
        }
    }
}
