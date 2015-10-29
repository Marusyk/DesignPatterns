using System.IO;
using System.Windows.Forms;
using System.Reflection;

// Пример со встроенной адаптацией интерфейсов.

namespace AdapterTreeViewCustomers
{
    public partial class Form1 : Form
    {
        private TreeDisplay treeDisplay;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Windows\assembly");
            this.treeDisplay = new DirectoryTreeDisplay();
            SettingsTreeDisplay();
            treeDisplay.Display(directoryInfo);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            this.treeDisplay = new AssemblyTreeDisplay();
            SettingsTreeDisplay();
            treeDisplay.Display(assembly);
        }

        // Настройки для TreeDisplay

        void SettingsTreeDisplay()
        {
            this.treeDisplay.Location = new System.Drawing.Point(40, 5);
            this.treeDisplay.Name = "treeDisplay";
            this.treeDisplay.Size = new System.Drawing.Size(300, 400);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(this.treeDisplay);
        }
    }
}
