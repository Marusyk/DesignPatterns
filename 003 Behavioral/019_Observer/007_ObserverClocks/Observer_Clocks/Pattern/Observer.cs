using System;

namespace Observer_Clocks
{
    abstract class Observer
    {
        public abstract void Update(Subject theChangedSubject);
    }
}
