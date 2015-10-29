using System;
using System.Drawing;
using System.Windows.Forms;

namespace WidgetFactoryApplication
{
    // ConcreteImplementor
    class MacWindowImp : WindowImp
    {
        public override Form DevDrawForm()
        {
            this.form = new Form();
            this.form.AutoScaleDimensions = new SizeF(6F, 13F);
            this.form.AutoScaleMode = AutoScaleMode.Font;
            this.form.ClientSize = new Size(284, 172);

            this.form.Name = "Mac Form";
            this.form.Text = "Mac OS - Snow Leopard";
            this.form.BackColor = Color.White;

            return this.form;
        }

        public override Button DevDrawButton()
        {
            this.button = new Button();
            this.button.Location = new Point(75, 70);
            this.button.Size = new Size(125, 25);
            this.button.Text = "Leopard";
            this.button.ForeColor = Color.White;
            this.button.BackColor = Color.LightGray;
            
            return this.button;
        }
    }
}
