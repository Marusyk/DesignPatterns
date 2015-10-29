using System.Windows.Forms;

namespace Mediator.Pattern
{
    class FontDialogDirector : DialogDirector
    {
        #region Widgets
        public FormFontChooser WorkForm { get; private set; }
        public MyListBox FontListBox { get; private set; }
        public EntryText FontSampleText { get; private set; }
        public FontBox FontTextBox { get; private set; }
        public FontSizeSelector FontSizeBox { get; private set; }
        public FontCondensedIndicator FontCondensed { get; private set; }
        public FontItalicSwitch FontItalicSW { get; private set; }
        public FontBoldSwitch FontBoldSW { get; private set; }
        #endregion

        public FontDialogDirector(FormFontChooser workForm)
        {
            this.WorkForm = workForm;
            CreateWidgets();
        }

        T FindControl<T>(string ctrl) where T : Control
        {
            return (WorkForm.Controls.Find(ctrl, false)[0] as T);
        }

        protected override void CreateWidgets()
        {
            FontListBox = new MyListBox(FindControl<ListBox>("lstBxFonts"), this);
            FontSampleText = new EntryText(FindControl<Label>("lblFontSample"), this);
            FontTextBox = new FontBox(FindControl<TextBox>("txtbxFamily"), this);
            FontSizeBox = new FontSizeSelector(FindControl<DomainUpDown>("domainSize"), this);
            FontCondensed = new FontCondensedIndicator(FindControl<CheckBox>("chckBxCondensed"), this);
            FontItalicSW = new FontItalicSwitch(FindControl<RadioButton>("radioItalic"), this);
            FontBoldSW = new FontBoldSwitch(FindControl<Panel>("weightPanel").Controls.Find("radioBold", false)[0] as RadioButton, this);
        }

        public override void WidgetChanged(Widget wdgt)
        {
            if (wdgt is MyListBox)
            {
                FontSampleText.changeTextFontFam((wdgt as MyListBox).listBoxWidget.SelectedItem.ToString());
                FontTextBox.SetFontName((wdgt as MyListBox).listBoxWidget.SelectedItem.ToString());
            }
            if (wdgt is FontSizeSelector)
            {
                FontSampleText.SetFontSize(int.Parse((wdgt as FontSizeSelector).DomSize.Text));
            }
            if (wdgt is FontCondensedIndicator)
            {
                FontSampleText.SetFontStrikeOut((wdgt as FontCondensedIndicator).CondensedIndicator.Checked);
            }
            if (wdgt is FontItalicSwitch)
            {
                FontSampleText.SetFontItalic((wdgt as FontItalicSwitch).ItalicBtn.Checked);
            }
            if (wdgt is FontBoldSwitch)
            {
                FontSampleText.SetFontBold((wdgt as FontBoldSwitch).BoldBtn.Checked);
            }
            if (wdgt is FontBox)
            {
                FontListBox.FindFontFamily((wdgt as FontBox).textBoxWidget.Text);
            }
        }
    }
}
