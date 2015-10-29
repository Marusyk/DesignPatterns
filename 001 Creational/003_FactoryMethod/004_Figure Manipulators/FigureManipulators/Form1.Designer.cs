namespace FigureManipulators
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.operation_btn = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.add_Line_btn = new System.Windows.Forms.ToolStripButton();
            this.add_Text_btn = new System.Windows.Forms.ToolStripButton();
            this.operation_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // operation_btn
            // 
            this.operation_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.operation_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.operation_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_btn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.operation_btn.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.operation_btn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_Line_btn,
            this.toolStripSeparator1,
            this.add_Text_btn});
            this.operation_btn.Location = new System.Drawing.Point(607, 0);
            this.operation_btn.Name = "operation_btn";
            this.operation_btn.Size = new System.Drawing.Size(32, 397);
            this.operation_btn.Stretch = true;
            this.operation_btn.TabIndex = 3;
            this.operation_btn.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(29, 6);
            // 
            // add_Line_btn
            // 
            this.add_Line_btn.BackColor = System.Drawing.Color.DarkRed;
            this.add_Line_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add_Line_btn.Image = global::FigureManipulators.Properties.Resources.line;
            this.add_Line_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_Line_btn.Name = "add_Line_btn";
            this.add_Line_btn.Size = new System.Drawing.Size(29, 29);
            this.add_Line_btn.Click += new System.EventHandler(this.add_Line_btn_Click);
            // 
            // add_Text_btn
            // 
            this.add_Text_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_Text_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add_Text_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_Text_btn.Image")));
            this.add_Text_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_Text_btn.Name = "add_Text_btn";
            this.add_Text_btn.Size = new System.Drawing.Size(29, 29);
            this.add_Text_btn.Click += new System.EventHandler(this.add_Text_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(639, 397);
            this.Controls.Add(this.operation_btn);
            this.Name = "Form1";
            this.Text = "Manipulators";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.operation_btn.ResumeLayout(false);
            this.operation_btn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DownClick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ToolStrip operation_btn;
        private System.Windows.Forms.ToolStripButton add_Line_btn;
        private System.Windows.Forms.ToolStripButton add_Text_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

