using System.Drawing;
using System.Windows.Forms;

namespace Subclassing
{
    partial class Form1
    {
        SubTextBox textBox1;

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.textBox1 = new Subclassing.SubTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(70, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(206, 26);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(350, 150);
            this.Controls.Add(this.textBox1);
            this.Text = "Subclassing";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
               
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }
    }
}

