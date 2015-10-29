using System;

namespace State
{
    // Состояние сильного гнева (S2)
    internal class StrongAngerState : State
    {
        internal StrongAngerState()
        {
            Console.WriteLine("Отец в состоянии сильного гнева:");
            BeatBelt();
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

        // y0
        private void BeatBelt()
        {
            Console.WriteLine("Бьет сына ремнем.");
        }
    }
}
