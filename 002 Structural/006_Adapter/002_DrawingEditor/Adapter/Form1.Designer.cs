namespace Adapter
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
            this.AddTextButton = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddLineButton = new System.Windows.Forms.ToolStripButton();
            this.operation_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // operation_btn
            // 
            this.operation_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.operation_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_btn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.operation_btn.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.operation_btn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddLineButton,
            this.toolStripSeparator1,
            this.AddTextButton});
            this.operation_btn.Location = new System.Drawing.Point(0, 0);
            this.operation_btn.Name = "operation_btn";
            this.operation_btn.Size = new System.Drawing.Size(639, 32);
            this.operation_btn.Stretch = true;
            this.operation_btn.TabIndex = 3;
            this.operation_btn.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // AddTextButton
            // 
            this.AddTextButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddTextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTextButton.Image = ((System.Drawing.Image)(resources.GetObject("AddTextButton.Image")));
            this.AddTextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTextButton.Name = "AddTextButton";
            this.AddTextButton.Size = new System.Drawing.Size(29, 29);
            this.AddTextButton.Text = "Текст";
            this.AddTextButton.Click += new System.EventHandler(this.AddTextButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Тест";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст : ";
            // 
            // AddLineButton
            // 
            this.AddLineButton.BackColor = System.Drawing.Color.Transparent;
            this.AddLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddLineButton.Image = global::Adapter.Properties.Resources.line;
            this.AddLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddLineButton.Name = "AddLineButton";
            this.AddLineButton.Size = new System.Drawing.Size(29, 29);
            this.AddLineButton.Text = "Линия";
            this.AddLineButton.Click += new System.EventHandler(this.AddLineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(639, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.operation_btn);
            this.Name = "Form1";
            this.Text = "Adapter";
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
        private System.Windows.Forms.ToolStripButton AddLineButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AddTextButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

