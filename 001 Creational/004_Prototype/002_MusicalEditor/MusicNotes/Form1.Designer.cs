namespace MusicNotes
{
    public  partial class Form1
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
        public void InitializeComponent()
        {
            this.btnWholeNote = new System.Windows.Forms.ToolStripButton();
            this.btnHalfNote = new System.Windows.Forms.ToolStripButton();
            this.btnQuarterNote = new System.Windows.Forms.ToolStripButton();
            this.btnEighthNote = new System.Windows.Forms.ToolStripButton();
            this.btnSixteenthNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRotate = new System.Windows.Forms.ToolStripButton();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDelNote = new System.Windows.Forms.ToolStripButton();
            this.btnUnMark = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.scoreSheetPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWholeNote
            // 
            this.btnWholeNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnWholeNote.Image = global::MusicNotes.Properties.Resources.WholeNote;
            this.btnWholeNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWholeNote.Name = "btnWholeNote";
            this.btnWholeNote.Size = new System.Drawing.Size(23, 22);
            this.btnWholeNote.Text = "Whole Note";
            this.btnWholeNote.Click += new System.EventHandler(this.btnWholeNote_Click);
            // 
            // btnHalfNote
            // 
            this.btnHalfNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHalfNote.Image = global::MusicNotes.Properties.Resources.HalfNote;
            this.btnHalfNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHalfNote.Name = "btnHalfNote";
            this.btnHalfNote.Size = new System.Drawing.Size(23, 22);
            this.btnHalfNote.Text = "Half Note";
            this.btnHalfNote.Click += new System.EventHandler(this.btnHalfNote_Click);
            // 
            // btnQuarterNote
            // 
            this.btnQuarterNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnQuarterNote.Image = global::MusicNotes.Properties.Resources.QuarterNote;
            this.btnQuarterNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuarterNote.Name = "btnQuarterNote";
            this.btnQuarterNote.Size = new System.Drawing.Size(23, 22);
            this.btnQuarterNote.Text = "Quarter Note";
            this.btnQuarterNote.Click += new System.EventHandler(this.btnQuarterNote_Click);
            // 
            // btnEighthNote
            // 
            this.btnEighthNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEighthNote.Image = global::MusicNotes.Properties.Resources.EighthNote;
            this.btnEighthNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEighthNote.Name = "btnEighthNote";
            this.btnEighthNote.Size = new System.Drawing.Size(23, 22);
            this.btnEighthNote.Text = "Eighth Note";
            this.btnEighthNote.Click += new System.EventHandler(this.btnEighthNote_Click);
            // 
            // btnSixteenthNote
            // 
            this.btnSixteenthNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSixteenthNote.Image = global::MusicNotes.Properties.Resources.SixteenthNote;
            this.btnSixteenthNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSixteenthNote.Name = "btnSixteenthNote";
            this.btnSixteenthNote.Size = new System.Drawing.Size(23, 22);
            this.btnSixteenthNote.Text = "Sixteenth Note";
            this.btnSixteenthNote.Click += new System.EventHandler(this.btnSixteenthNote_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAbove
            // 
            this.btnAbove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbove.Image = global::MusicNotes.Properties.Resources.Up;
            this.btnAbove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbove.Name = "btnAbove";
            this.btnAbove.Size = new System.Drawing.Size(23, 22);
            this.btnAbove.Text = "Up Note";
            this.btnAbove.Click += new System.EventHandler(this.btnAbove_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRotate
            // 
            this.btnRotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotate.Image = global::MusicNotes.Properties.Resources.Rotate;
            this.btnRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(23, 22);
            this.btnRotate.Text = "Rotate Note";
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlay.Enabled = false;
            this.btnPlay.Image = global::MusicNotes.Properties.Resources.Play;
            this.btnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(23, 22);
            this.btnPlay.Text = "Play Melody";
            this.btnPlay.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML files|*.xml";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "XML files|*.xml";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1229, 35);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(143, 30);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(143, 30);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(143, 30);
            this.saveAsToolStripMenuItem1.Text = "Save as";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWholeNote,
            this.btnHalfNote,
            this.btnQuarterNote,
            this.btnEighthNote,
            this.btnSixteenthNote,
            this.toolStripSeparator1,
            this.btnAbove,
            this.btnRotate,
            this.btnDelNote,
            this.btnUnMark,
            this.toolStripSeparator2,
            this.btnPlay,
            this.btnClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1229, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDelNote
            // 
            this.btnDelNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelNote.Enabled = false;
            this.btnDelNote.Image = global::MusicNotes.Properties.Resources.erase;
            this.btnDelNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelNote.Name = "btnDelNote";
            this.btnDelNote.Size = new System.Drawing.Size(23, 22);
            this.btnDelNote.Text = " Delete Note";
            this.btnDelNote.Click += new System.EventHandler(this.btnDelNote_Click);
            // 
            // btnUnMark
            // 
            this.btnUnMark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnMark.Image = global::MusicNotes.Properties.Resources.deselect_16;
            this.btnUnMark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnMark.Name = "btnUnMark";
            this.btnUnMark.Size = new System.Drawing.Size(23, 22);
            this.btnUnMark.Text = "Deselect all";
            this.btnUnMark.Click += new System.EventHandler(this.btnUnMark_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = global::MusicNotes.Properties.Resources.Clear;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 22);
            this.btnClear.Text = "Clear Sheet";
            this.btnClear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // scoreSheetPanel
            // 
            this.scoreSheetPanel.AutoScroll = true;
            this.scoreSheetPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreSheetPanel.Location = new System.Drawing.Point(44, 0);
            this.scoreSheetPanel.Margin = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.scoreSheetPanel.MaximumSize = new System.Drawing.Size(1500, 7500);
            this.scoreSheetPanel.MinimumSize = new System.Drawing.Size(1500, 2700);
            this.scoreSheetPanel.Name = "scoreSheetPanel";
            this.scoreSheetPanel.Size = new System.Drawing.Size(1500, 2700);
            this.scoreSheetPanel.TabIndex = 21;
            this.scoreSheetPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.scoreSheetPanel_ControlAdded);
            this.scoreSheetPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.scoreSheetPanel_ControlRemoved);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.scoreSheetPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 572);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1229, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(792, 510);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Music Notes: Pattern \"Prototype\"";
            this.ResizeEnd += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnWholeNote;
        private System.Windows.Forms.ToolStripButton btnHalfNote;
        private System.Windows.Forms.ToolStripButton btnQuarterNote;
        private System.Windows.Forms.ToolStripButton btnEighthNote;
        private System.Windows.Forms.ToolStripButton btnSixteenthNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAbove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRotate;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.Panel scoreSheetPanel;
        private System.Windows.Forms.ToolStripButton btnUnMark;
        private System.Windows.Forms.ToolStripButton btnDelNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

