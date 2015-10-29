using System.Windows.Forms;

namespace AdapterTreeViewCustomers
{
    // TreeDisplay - (Target) : TreeView - (BaseTarget)
    abstract class TreeDisplay : TreeView
    {
        public abstract void Display(object tree);
    }
}
