using System;

namespace State
{
    // Состояние гнева (S4)
    internal class AngerState : State
    {
        internal AngerState()
        {
            Console.WriteLine("Отец в состоянии гнева:");
            Scold();
        }

        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    {
                        father.State = new StrongAngerState(); // S2
                        break;
                    }
                case Mark.Five:
                    {
                        father.State = new NeutralState(); // S0
                        break;
                    }
            }
        }

        // y1
        private void Scold()
        {
            Console.WriteLine("Ругает сына.");
        }
    }
}
