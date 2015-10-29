namespace Mediator
{
    partial class FormFontChooser
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
            this.lblFamily = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSlant = new System.Windows.Forms.Label();
            this.txtbxFamily = new System.Windows.Forms.TextBox();
            this.lblFontSample = new System.Windows.Forms.Label();
            this.lstBxFonts = new System.Windows.Forms.ListBox();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioBold = new System.Windows.Forms.RadioButton();
            this.radioDemiBold = new System.Windows.Forms.RadioButton();
            this.radioRoman = new System.Windows.Forms.RadioButton();
            this.radioItalic = new System.Windows.Forms.RadioButton();
            this.radioOblique = new System.Windows.Forms.RadioButton();
            this.domainSize = new System.Windows.Forms.DomainUpDown();
            this.chckBxCondensed = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.weightPanel = new System.Windows.Forms.Panel();
            this.weightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(20, 123);
            this.lblFamily.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(54, 20);
            this.lblFamily.TabIndex = 0;
            this.lblFamily.Text = "Family";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 454);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(59, 20);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(33, 548);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 20);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            // 
            // lblSlant
            // 
            this.lblSlant.AutoSize = true;
            this.lblSlant.Location = new System.Drawing.Point(27, 500);
            this.lblSlant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlant.Name = "lblSlant";
            this.lblSlant.Size = new System.Drawing.Size(46, 20);
            this.lblSlant.TabIndex = 3;
            this.lblSlant.Text = "Slant";
            // 
            // txtbxFamily
            // 
            this.txtbxFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtbxFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbxFamily.Location = new System.Drawing.Point(81, 118);
            this.txtbxFamily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxFamily.Name = "txtbxFamily";
            this.txtbxFamily.Size = new System.Drawing.Size(414, 26);
            this.txtbxFamily.TabIndex = 4;
            this.txtbxFamily.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxFamily_KeyPress);
            // 
            // lblFontSample
            // 
            this.lblFontSample.AutoSize = true;
            this.lblFontSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFontSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFontSample.Location = new System.Drawing.Point(0, 0);
            this.lblFontSample.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFontSample.Name = "lblFontSample";
            this.lblFontSample.Size = new System.Drawing.Size(247, 29);
            this.lblFontSample.TabIndex = 5;
            this.lblFontSample.Text = "The quick brown fox...";
            // 
            // lstBxFonts
            // 
            this.lstBxFonts.FormattingEnabled = true;
            this.lstBxFonts.ItemHeight = 20;
            this.lstBxFonts.Location = new System.Drawing.Point(81, 160);
            this.lstBxFonts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBxFonts.Name = "lstBxFonts";
            this.lstBxFonts.Size = new System.Drawing.Size(414, 264);
            this.lstBxFonts.TabIndex = 6;
            this.lstBxFonts.SelectedValueChanged += new System.EventHandler(this.lstBxFonts_SelectedValueChanged);
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Checked = true;
            this.radioMedium.Location = new System.Drawing.Point(0, 5);
            this.radioMedium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(90, 24);
            this.radioMedium.TabIndex = 7;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioBold
            // 
            this.radioBold.AutoSize = true;
            this.radioBold.Location = new System.Drawing.Point(100, 5);
            this.radioBold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBold.Name = "radioBold";
            this.radioBold.Size = new System.Drawing.Size(64, 24);
            this.radioBold.TabIndex = 8;
            this.radioBold.Text = "bold";
            this.radioBold.UseVisualStyleBackColor = true;
            this.radioBold.CheckedChanged += new System.EventHandler(this.radioBold_CheckedChanged);
            // 
            // radioDemiBold
            // 
            this.radioDemiBold.AutoSize = true;
            this.radioDemiBold.Enabled = false;
            this.radioDemiBold.Location = new System.Drawing.Point(178, 5);
            this.radioDemiBold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioDemiBold.Name = "radioDemiBold";
            this.radioDemiBold.Size = new System.Drawing.Size(98, 24);
            this.radioDemiBold.TabIndex = 9;
            this.radioDemiBold.Text = "demibold";
            this.radioDemiBold.UseVisualStyleBackColor = true;
            // 
            // radioRoman
            // 
            this.radioRoman.AutoSize = true;
            this.radioRoman.Checked = true;
            this.radioRoman.Location = new System.Drawing.Point(82, 497);
            this.radioRoman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioRoman.Name = "radioRoman";
            this.radioRoman.Size = new System.Drawing.Size(79, 24);
            this.radioRoman.TabIndex = 10;
            this.radioRoman.TabStop = true;
            this.radioRoman.Text = "roman";
            this.radioRoman.UseVisualStyleBackColor = true;
            // 
            // radioItalic
            // 
            this.radioItalic.AutoSize = true;
            this.radioItalic.Location = new System.Drawing.Point(183, 497);
            this.radioItalic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioItalic.Name = "radioItalic";
            this.radioItalic.Size = new System.Drawing.Size(65, 24);
            this.radioItalic.TabIndex = 11;
            this.radioItalic.Text = "italic";
            this.radioItalic.UseVisualStyleBackColor = true;
            this.radioItalic.CheckedChanged += new System.EventHandler(this.radioItalic_CheckedChanged);
            // 
            // radioOblique
            // 
            this.radioOblique.AutoSize = true;
            this.radioOblique.Enabled = false;
            this.radioOblique.Location = new System.Drawing.Point(261, 497);
            this.radioOblique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioOblique.Name = "radioOblique";
            this.radioOblique.Size = new System.Drawing.Size(85, 24);
            this.radioOblique.TabIndex = 12;
            this.radioOblique.Text = "oblique";
            this.radioOblique.UseVisualStyleBackColor = true;
            // 
            // domainSize
            // 
            this.domainSize.Items.Add("30");
            this.domainSize.Items.Add("29");
            this.domainSize.Items.Add("28");
            this.domainSize.Items.Add("27");
            this.domainSize.Items.Add("26");
            this.domainSize.Items.Add("25");
            this.domainSize.Items.Add("24");
            this.domainSize.Items.Add("23");
            this.domainSize.Items.Add("22");
            this.domainSize.Items.Add("21");
            this.domainSize.Items.Add("20");
            this.domainSize.Items.Add("19");
            this.domainSize.Items.Add("18");
            this.domainSize.Items.Add("17");
            this.domainSize.Items.Add("16");
            this.domainSize.Items.Add("15");
            this.domainSize.Items.Add("14");
            this.domainSize.Items.Add("13");
            this.domainSize.Items.Add("12");
            this.domainSize.Items.Add("11");
            this.domainSize.Items.Add("10");
            this.domainSize.Items.Add("9");
            this.domainSize.Items.Add("8");
            this.domainSize.Location = new System.Drawing.Point(81, 545);
            this.domainSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.domainSize.Name = "domainSize";
            this.domainSize.Size = new System.Drawing.Size(68, 26);
            this.domainSize.TabIndex = 4;
            this.domainSize.Text = "12";
            this.domainSize.Wrap = true;
            this.domainSize.TextChanged += new System.EventHandler(this.domainSize_TextChanged);
            this.domainSize.Validated += new System.EventHandler(this.domainSize_Validated);
            // 
            // chckBxCondensed
            // 
            this.chckBxCondensed.AutoSize = true;
            this.chckBxCondensed.Location = new System.Drawing.Point(183, 548);
            this.chckBxCondensed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckBxCondensed.Name = "chckBxCondensed";
            this.chckBxCondensed.Size = new System.Drawing.Size(114, 24);
            this.chckBxCondensed.TabIndex = 14;
            this.chckBxCondensed.Text = "condensed";
            this.chckBxCondensed.UseVisualStyleBackColor = true;
            this.chckBxCondensed.CheckedChanged += new System.EventHandler(this.chckBxCondensed_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 594);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(384, 594);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // weightPanel
            // 
            this.weightPanel.Controls.Add(this.radioDemiBold);
            this.weightPanel.Controls.Add(this.radioBold);
            this.weightPanel.Controls.Add(this.radioMedium);
            this.weightPanel.Location = new System.Drawing.Point(82, 446);
            this.weightPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weightPanel.Name = "weightPanel";
            this.weightPanel.Size = new System.Drawing.Size(414, 42);
            this.weightPanel.TabIndex = 17;
            // 
            // FormFontChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 657);
            this.Controls.Add(this.weightPanel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chckBxCondensed);
            this.Controls.Add(this.domainSize);
            this.Controls.Add(this.radioOblique);
            this.Controls.Add(this.radioItalic);
            this.Controls.Add(this.radioRoman);
            this.Controls.Add(this.lstBxFonts);
            this.Controls.Add(this.lblFontSample);
            this.Controls.Add(this.txtbxFamily);
            this.Controls.Add(this.lblSlant);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblFamily);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFontChooser";
            this.Text = "Font Chooser";
            this.weightPanel.ResumeLayout(false);
            this.weightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSlant;
        private System.Windows.Forms.TextBox txtbxFamily;
        private System.Windows.Forms.Label lblFontSample;
        private System.Windows.Forms.ListBox lstBxFonts;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioBold;
        private System.Windows.Forms.RadioButton radioDemiBold;
        private System.Windows.Forms.RadioButton radioRoman;
        private System.Windows.Forms.RadioButton radioItalic;
        private System.Windows.Forms.RadioButton radioOblique;
        private System.Windows.Forms.DomainUpDown domainSize;
        private System.Windows.Forms.CheckBox chckBxCondensed;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel weightPanel;
    }
}

