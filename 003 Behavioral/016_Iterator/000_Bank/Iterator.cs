using System;

namespace Enumerator
{
    interface IEnumerator
    {
        bool MoveNext();
        void Reset();
        object Current { get; }
    }
}