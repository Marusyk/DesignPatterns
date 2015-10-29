using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilationSystem
{
    class ExpressionNode : ProgramNode
    {
        List<ProgramNode> nodes = new List<ProgramNode>();

        public override void AddNode(ProgramNode node)
        {
            nodes.Add(node);
        }

        public override void Traverse(CodeGenerator generator)
        {
            foreach (var item in nodes)
            {
                item.Traverse(generator);
            }
        }
    }
}
