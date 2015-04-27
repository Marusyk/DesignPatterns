using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMyExcample
{
    class Enumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return "Element";
        }
    }
}
