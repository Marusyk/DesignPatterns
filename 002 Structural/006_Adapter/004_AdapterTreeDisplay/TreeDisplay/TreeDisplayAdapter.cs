using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace AdapterTreeViewCustomers
{
    // TreeDisplay - (Adapter) : TreeView - (Target)
    class TreeDisplay : TreeView
    {
        public void Display(object tree)
        {
            if (tree is DirectoryInfo)
                DisplaySubdirectories(tree as DirectoryInfo);
            else if (tree is Assembly)
                DisplayTypeMembers(tree as Assembly);
            else
                throw new ArgumentException();
        }

        void DisplaySubdirectories(DirectoryInfo directoryInfo)
        {
            this.Nodes.Clear();

            IEnumerable<DirectoryInfo> enumerable = directoryInfo.EnumerateDirectories();
            List<DirectoryInfo> directories = enumerable.ToList<DirectoryInfo>();

            foreach (DirectoryInfo directory in directories)
            {
                this.Nodes.Add(new TreeNode(directory.Name));

                foreach (FileInfo file in directory.GetFiles())
                    this.Nodes[directories.IndexOf(directory)].Nodes.Add(new TreeNode(file.Name));

                // TODO: ... некоторая логика по работе с файловой системой ...
            }
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
