using System;
using System.Windows.Forms;

namespace Observer_Clocks
{
    public partial class ClockForm : Form
    {
        Subject subject = new ClockTimer();

        public ClockForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnalogClock c = new AnalogClock(this, subject);
            DigitalClock cl = new DigitalClock(this, subject);
            cl.GetControl.Top = 110;
            cl.GetControl.Left = 30;
        }
    }
}
