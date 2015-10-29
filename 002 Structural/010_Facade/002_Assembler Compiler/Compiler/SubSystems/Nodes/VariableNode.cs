using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilationSystem
{
    class VariableNode : ProgramNode
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public byte[] Address { get; set; }


        public VariableNode(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public override void AddNode(ProgramNode node)
        {
            throw new InvalidOperationException();
        }

        public override void Traverse(CodeGenerator generator)
        {
            generator.SetDataVariable(this);
        }
    }
}
