using System;

namespace Enumerator
{
    interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
}