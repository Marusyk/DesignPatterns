using System.IO;
using System.Windows.Forms;
using System.Reflection;

// Пример со встроенной адаптацией интерфейсов.

namespace AdapterTreeViewCustomers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Windows\assembly");
            treeDisplay.Display(directoryInfo);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            treeDisplay.Display(assembly);
        }
    }
}
