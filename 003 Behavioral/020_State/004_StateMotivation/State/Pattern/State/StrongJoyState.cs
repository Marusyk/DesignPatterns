using System;

namespace State
{
    // Состояние сильной радости (S5)
    internal class StrongJoyState : State
    {
        internal StrongJoyState()
        {
            Console.WriteLine("Отец в состоянии сильной радости:");
            Exult();
        }

        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    {
                        father.State = new PityState(); // S1
                        break;
                    }
                case Mark.Five:
                    {
                        father.State = new StrongJoyState(); // S5
                        break;
                    }
            }
        }

        // y5
        private void Exult()
        {
            Console.WriteLine("Ликует и гордится сыном.");
        }
    }
}
