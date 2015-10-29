using System;
using System.Drawing;

namespace WidgetFactoryApplication
{
    class LinuxForm : AbstractWindow
    {
        public LinuxForm()
            : base()
        {
            InitializeComponent();
        }

        public override void AddToCollection(AbstractButton button)
        {
            this.Controls.Add(button);
        }

        public void InitializeComponent()
        {
            this.Name = "linuxForm";
            this.Text = "Linux - Gnom";
            this.BackColor = Color.Yellow;
        }
    }
}
