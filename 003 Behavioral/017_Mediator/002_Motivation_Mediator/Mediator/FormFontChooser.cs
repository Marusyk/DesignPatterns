using System;
using System.Drawing;
using System.Windows.Forms;
using Mediator.Pattern;

namespace Mediator
{
    public partial class FormFontChooser : Form
    {
        FontDialogDirector fntDlgDir;
        public FormFontChooser()
        {
            InitializeComponent();
            fntDlgDir = new FontDialogDirector(this);
            foreach (var fontFam in FontFamily.Families)
            {
                lstBxFonts.Items.Add(fontFam.Name);
                txtbxFamily.AutoCompleteCustomSource.Add(fontFam.Name);
            }

        }
        private void lstBxFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            fntDlgDir.FontListBox.Changed();
        }

        private void domainSize_TextChanged(object sender, EventArgs e)
        {
            #region Check entered value
            int parsedItem;
            if (!int.TryParse(domainSize.Text, out parsedItem) || parsedItem > 30 || parsedItem == 0)
                domainSize.Text = "30";
            #endregion
            fntDlgDir.FontSizeBox.Changed();
        }

        private void domainSize_Validated(object sender, EventArgs e)
        {
            #region Check entered value
            int parsedItem;
            if (!int.TryParse(domainSize.Text, out parsedItem) || parsedItem < 8 || parsedItem == 0)
                domainSize.Text = "8";
            #endregion
            fntDlgDir.FontSizeBox.Changed();
        }

        private void chckBxCondensed_CheckedChanged(object sender, EventArgs e)
        {
            fntDlgDir.FontCondensed.Changed();
        }

        private void radioItalic_CheckedChanged(object sender, EventArgs e)
        {
            fntDlgDir.FontItalicSW.Changed();
        }

        private void radioBold_CheckedChanged(object sender, EventArgs e)
        {
            fntDlgDir.FontBoldSW.Changed();
        }

        private void txtbxFamily_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                fntDlgDir.FontTextBox.Changed();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
