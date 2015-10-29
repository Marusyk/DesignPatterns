using System;

// Адаптер (Уровень класса).

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            ITarget target = new Adapter();
            target.Request();
        }
    }
}
