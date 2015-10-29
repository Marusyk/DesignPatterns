namespace Document_Converter
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGetASCII = new System.Windows.Forms.Button();
            this.btnGetPDF = new System.Windows.Forms.Button();
            this.btnGetWidget = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"RTF Document\"|*.rtf";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnGetASCII
            // 
            this.btnGetASCII.Enabled = false;
            this.btnGetASCII.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetASCII.Location = new System.Drawing.Point(12, 65);
            this.btnGetASCII.Name = "btnGetASCII";
            this.btnGetASCII.Size = new System.Drawing.Size(117, 26);
            this.btnGetASCII.TabIndex = 1;
            this.btnGetASCII.Text = "Get ASCII";
            this.btnGetASCII.UseVisualStyleBackColor = true;
            this.btnGetASCII.Click += new System.EventHandler(this.btnGetASCII_Click);
            // 
            // btnGetPDF
            // 
            this.btnGetPDF.Enabled = false;
            this.btnGetPDF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetPDF.Location = new System.Drawing.Point(135, 65);
            this.btnGetPDF.Name = "btnGetPDF";
            this.btnGetPDF.Size = new System.Drawing.Size(117, 26);
            this.btnGetPDF.TabIndex = 2;
            this.btnGetPDF.Text = "Get PDF";
            this.btnGetPDF.UseVisualStyleBackColor = true;
            this.btnGetPDF.Click += new System.EventHandler(this.btnGetPDF_Click);
            // 
            // btnGetWidget
            // 
            this.btnGetWidget.Enabled = false;
            this.btnGetWidget.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetWidget.Location = new System.Drawing.Point(258, 65);
            this.btnGetWidget.Name = "btnGetWidget";
            this.btnGetWidget.Size = new System.Drawing.Size(117, 26);
            this.btnGetWidget.TabIndex = 3;
            this.btnGetWidget.Text = "Get Widget";
            this.btnGetWidget.UseVisualStyleBackColor = true;
            this.btnGetWidget.Click += new System.EventHandler(this.btnGetWidget_Click);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedFile.Location = new System.Drawing.Point(12, 33);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(144, 19);
            this.lblSelectedFile.TabIndex = 4;
            this.lblSelectedFile.Text = "Please select the file";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 111);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.btnGetWidget);
            this.Controls.Add(this.btnGetPDF);
            this.Controls.Add(this.btnGetASCII);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 150);
            this.MinimumSize = new System.Drawing.Size(405, 150);
            this.Name = "Form1";
            this.Text = "Document Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGetASCII;
        private System.Windows.Forms.Button btnGetPDF;
        private System.Windows.Forms.Button btnGetWidget;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

