using System;

namespace Enumerator
{
    class Program
    {
        static void Main()
        {
            IEnumerable bank = new Bank();

            IEnumerator cashier = bank.GetEnumerator();

            while(cashier.MoveNext())
            {
                Banknote banknote = cashier.Current as Banknote;
                Console.WriteLine(banknote.Nominal);
            }            

            // Delay.
            Console.ReadKey();
        }
    }
}