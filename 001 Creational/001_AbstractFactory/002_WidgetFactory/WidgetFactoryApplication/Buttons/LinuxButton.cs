using System.Drawing;

namespace WidgetFactoryApplication
{
    class LinuxButton : AbstractButton
    {
        public LinuxButton()
            : base()
        {
            this.Text = "Linux";
            this.ForeColor = Color.DarkGreen;
            this.BackColor = Color.LightGreen;
        }
    }
}
