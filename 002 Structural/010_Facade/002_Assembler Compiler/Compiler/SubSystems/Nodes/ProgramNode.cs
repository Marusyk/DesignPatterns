using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilationSystem
{
    abstract class ProgramNode
    {
        public ByteCode ProgramByteCode { get; set; }
        public abstract void Traverse(CodeGenerator generator);
        public abstract void AddNode(ProgramNode node);
    }
}
