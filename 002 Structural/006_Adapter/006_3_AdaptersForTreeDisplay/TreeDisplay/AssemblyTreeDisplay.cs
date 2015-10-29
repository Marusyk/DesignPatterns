using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AdapterTreeViewCustomers
{
    class AssemblyTreeDisplay : TreeDisplay
    {
        public override void Display(object tree)
        {
            if (tree is Assembly)
                DisplayTypeMembers(tree as Assembly);
            else
                throw new ArgumentException();
        }
        
        void DisplayTypeMembers(Assembly assembly)
        {
            this.Nodes.Clear();

            List<Type> types = assembly.GetTypes().ToList();

            foreach (Type type in types)
            {
                this.Nodes.Add(new TreeNode(type.Name));

                foreach (MemberInfo member in type.GetMembers().ToList())
                    this.Nodes[types.IndexOf(type)].Nodes.Add(new TreeNode(member.MemberType + " " + member.Name));

                // TODO: ... некоторая логика по работе с механизмами рефлексии ...
            }
        }
    }
}
