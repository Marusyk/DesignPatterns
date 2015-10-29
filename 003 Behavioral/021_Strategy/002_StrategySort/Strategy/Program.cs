using System;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            var sort = new SelectionSort();
            var context = new Context(sort);
            context.Sort();
            context.PrintArray();           
        }
    }
}
