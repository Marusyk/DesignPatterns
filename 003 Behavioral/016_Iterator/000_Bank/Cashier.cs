
namespace Enumerator
{
    class Cashier : IEnumerator
    {
        private Bank bank;
        private int current = -1;

        public Cashier(Bank enumerable)
        {
            this.bank = enumerable;
        }

        // Реализация интерфейса IEnumerator.
        public bool MoveNext()
        {
            if (current < bank.Count - 1)
            {
                current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = -1;
        }

        public object Current
        {
            get { return bank[current]; }
        }
    }
}