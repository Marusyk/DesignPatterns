using System;
using System.Windows.Forms;

namespace Observer_Clocks
{
    class DigitalClock : Observer
    {
        Label digitalClockLabel;
        Subject subject;
        TimeSpan time;

        public Control GetControl
        {
            get { return digitalClockLabel; }
        }

        public DigitalClock(Control parent, Subject subject)
        {
            digitalClockLabel = new Label { Parent = parent };
            this.subject = subject;
            subject.Attach(this);
        }

        public override void Update(Subject theChangedSubject)
        {
            time = (theChangedSubject as ClockTimer).GetTime();
            digitalClockLabel.BeginInvoke(new Action(Draw));
        }

        public void Draw()
        {
            digitalClockLabel.Text = time.ToString("hh\\:mm\\:ss");
        }
    }
}
