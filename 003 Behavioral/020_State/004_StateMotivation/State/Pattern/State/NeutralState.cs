using System;

namespace State
{
    // Нейтральное состояние (S0)
    internal class NeutralState : State
    {
        internal NeutralState()
        {
            Console.WriteLine("Отец в нейтральном состоянии:");
            Hope();
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
                        father.State = new JoyState();  // S3
                        break;
                    }
            }
        }

        // y3
        private void Hope()
        {
            Console.WriteLine("Надеется на хорошие оценки.");
        }
    }
}
