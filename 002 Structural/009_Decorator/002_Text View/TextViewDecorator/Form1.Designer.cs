namespace TextViewDecorator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьТекстовоеПолеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРамкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТекстовоеПолеToolStripMenuItem,
            this.добавитьРамкуToolStripMenuItem,
            this.добавитьScrollToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьТекстовоеПолеToolStripMenuItem
            // 
            this.добавитьТекстовоеПолеToolStripMenuItem.Name = "добавитьТекстовоеПолеToolStripMenuItem";
            this.добавитьТекстовоеПолеToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.добавитьТекстовоеПолеToolStripMenuItem.Text = "Добавить текстовое поле";
            this.добавитьТекстовоеПолеToolStripMenuItem.Click += new System.EventHandler(this.AddTextView);
            // 
            // добавитьРамкуToolStripMenuItem
            // 
            this.добавитьРамкуToolStripMenuItem.Name = "добавитьРамкуToolStripMenuItem";
            this.добавитьРамкуToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.добавитьРамкуToolStripMenuItem.Text = "Добавить рамку";
            this.добавитьРамкуToolStripMenuItem.Click += new System.EventHandler(this.AddBorder);
            // 
            // добавитьScrollToolStripMenuItem
            // 
            this.добавитьScrollToolStripMenuItem.Name = "добавитьScrollToolStripMenuItem";
            this.добавитьScrollToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.добавитьScrollToolStripMenuItem.Text = "Добавить Scroll";
            this.добавитьScrollToolStripMenuItem.Click += new System.EventHandler(this.AddScroll);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.CloseSolution);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 265);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pattern Decorator-TextView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьТекстовоеПолеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРамкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьScrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;

    }
}

