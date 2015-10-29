using System;

namespace Facade
{
    class Program
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.OperationAB();
            facade.OperationBC();
        }
    }
}
