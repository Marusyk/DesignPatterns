using System.IO;
using System.Windows.Forms;

namespace FactoryMethod.Pattern
{
    // ConcreteProductA
    public class TextDocument : Document
    {
        TextDocForm childForm;
        OpenFileDialog openFile;
        RichTextBox inputText;
        RichTextBox interimText;
        SaveFileDialog saveFile;
        Action action;
        string fileName;

        public TextDocument(Form baseForm, int counter, Action action)
        {
            this.action = action;
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            inputText = new RichTextBox();
            interimText = new RichTextBox();

            openFile.Filter = saveFile.Filter = @"Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FileName = saveFile.FileName = @"Document";

            childForm = new TextDocForm(baseForm, this);
            childForm.WindowState = FormWindowState.Maximized;
            fileName = childForm.Text = string.Format(@"Document{0}", counter);

            if (action == Action.NewDoc)
                childForm.Show();
        }

        public override void Open()
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                action = Action.OpenDoc;
                fileName = openFile.FileName;
                var docName = new FileInfo(fileName);
                childForm.Text = docName.Name;
                inputText.Text = File.ReadAllText(fileName);
                childForm.Show();
                interimText.Text = inputText.Text;
                childForm.ShowText(inputText);
            }
        }

        public override void SaveAs()
        {
            interimText.Text = inputText.Text;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                action = Action.OpenDoc;
                fileName = saveFile.FileName;
                File.WriteAllText(fileName, inputText.Text);
            }
        }

        public override void Clear()
        {
            childForm.ShowText(interimText);
        }

        public override void Close()
        {
            var result = MessageBox.Show(@"Вы действительно хотите закрыть документ?", @"Закрытие документа",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question,
                                          MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                childForm.Close();
            }
        }
    }
}
