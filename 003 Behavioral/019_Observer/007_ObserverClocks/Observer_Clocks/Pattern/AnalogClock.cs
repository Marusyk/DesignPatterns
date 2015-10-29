using System;
using System.Drawing;
using System.Windows.Forms;

namespace Observer_Clocks
{
    class AnalogClock : Observer
    {
        class AnalogClockPanel : Panel
        {
            public AnalogClockPanel()
            {
                SetStyle(ControlStyles.UserPaint |
                         ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint,
                         true);
                DoubleBuffered = true;
            }
        }

        Panel analogClockPanel;
        Subject subject;
        TimeSpan time;
        Point center = new Point(50, 50);

        public AnalogClock(Control parent, Subject subject)
        {
            analogClockPanel = new AnalogClockPanel() { Parent = parent };

            analogClockPanel.Size = new System.Drawing.Size(100, 100);
            this.subject = subject;
            subject.Attach(this);
        }

        public Control GetControl
        {
            get { return analogClockPanel; }
        }

        public override void Update(Subject theChangedSubject)
        {
            time = (theChangedSubject as ClockTimer).GetTime();
            analogClockPanel.Invoke(new Action(Draw));
        }

        public void Draw()
        {
            analogClockPanel.Refresh();
            var g = analogClockPanel.CreateGraphics();
            var rr = analogClockPanel.ClientRectangle;
            rr.Width -= 1;
            rr.Height -= 1;
            g.DrawEllipse(new Pen(Color.Black, 1), rr);

            for (int i = 0; i < 12; i++)
            {
                var rrr = (float)(Math.PI * 2f) / 60f * (float)(i * 5);
                var from = GetDestinationPoint(rrr, 45);
                var to = GetDestinationPoint(rrr, 50);
                drawLine(g, from, to, new Pen(Color.Blue, 2));
            }

            drawW(g, (float)(Math.PI * 2f) / 12f * (float)(time.Hours % 12), 30, new Pen(Color.Blue, 5));
            drawW(g, (float)(Math.PI * 2f) / 60f * (float)time.Minutes, 45, new Pen(Color.Green, 3));
            drawW(g, (float)(Math.PI * 2f) / 60f * (float)time.Seconds, 50, new Pen(Color.Red, 2));
        }

        Point GetDestinationPoint(float radians, int length)
        {
            int a = center.Y - (int)(Math.Cos(radians) * (float)length);
            int b = center.X + (int)(Math.Sin(radians) * (float)length);
            return new Point(b, a);
        }

        void drawLine(Graphics g, Point from, Point to, Pen p)
        {
            g.DrawLine(p, from, to);
        }

        void drawW(Graphics g, float radians, int length, Pen p)
        {

            drawLine(g, center, GetDestinationPoint(radians, length), p);
        }
    }
}
