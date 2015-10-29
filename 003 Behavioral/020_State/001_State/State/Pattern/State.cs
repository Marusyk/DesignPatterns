using System;

namespace State
{
    abstract class State
    {
        public abstract void Handle(Context context);
    }
}
