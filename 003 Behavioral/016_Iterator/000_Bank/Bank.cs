using System.Collections.Generic;

namespace Enumerator
{
    class Bank : IEnumerable
    {
        List<Banknote> bankVault = new List<Banknote>
            {
                new Banknote(), new Banknote(), 
                new Banknote(), new Banknote()
            };

        public Banknote this[int index]
        {
            get { return bankVault[index]; }
            set { bankVault.Insert(index, value); }
        }

        public int Count
        {
            get { return bankVault.Count; }
        }

        // Реализация интерфейса IEnumerable.
        public IEnumerator GetEnumerator()
        {
            return new Cashier(this);
        }
    }
}