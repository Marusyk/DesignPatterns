using System;

namespace ClassLibrary
{
    // ------------------------- Фасад (Открытый класс). -------------------------

    public class Facade
    {
        public void Method()
        {
            new SubsystemClassA().MethodA();
            new SubsystemClassB().MethodB();
        }
    }

    // ----------------     Классы подсистем (Закрытые классы). ------------------

    // По умолчанию все классы - internal.

    internal class SubsystemClassA 
    {
        public void MethodA() { Console.WriteLine("SubsystemClassA"); }
    }

    internal class SubsystemClassB
    {
        public void MethodB() { Console.WriteLine("SubsystemClassB"); }
    } 
}
