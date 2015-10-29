using System;

namespace State
{
    // Состояние жалости (S1)
    internal class PityState : State
    {
        internal PityState()
        {
            Console.WriteLine("Отец в состоянии жалости:");
            Calm();
        }

        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    {
                        father.State = new AngerState(); // S4
                        break;
                    }
                case Mark.Five:
                    {
                        father.State = new NeutralState(); // S0
                        break;
                    }
            }
        }

        // y2
        private void Calm()
        {
            Console.WriteLine("Успокаивает сына.");
        }
    }
}
