using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilationSystem
{
    class StatementNode : ProgramNode
    {
        public StatementNode()
        {
            Offsets = new List<int>();
        }

        public StatementNode(string name, string[] parameters)
        {
            Name = name;
            Parameters = parameters;
            Offsets = new List<int>();
        }

        public string Name { get; set; }
        public List<int> Offsets { get; set; }
        public int Address { get; set; }
        public string[] Parameters { get; set; }

        public override void AddNode(ProgramNode node)
        {
            throw new InvalidOperationException();
        }

        public override void Traverse(CodeGenerator generator)
        {
            ByteCode byteCode = null;

            Command parsedCommand = (Command)Enum.Parse(typeof(Command), Name);
            
            switch (parsedCommand)
            {
                case Command.MOV:
                    byteCode = generator.GetMovCode(Parameters);
                    break;
                case Command.ADD:
                    byteCode = generator.GetAddCode(Parameters);
                    break;
                case Command.SUB:
                    byteCode = generator.GetSubCode(Parameters);
                    break;
                case Command.XOR:
                    byteCode = generator.GetXorCode(Parameters);
                    break;
                case Command.CALL:
                    {
                        StatementNode function = generator.functions.Where(x => x.Name == Parameters[0]).FirstOrDefault();

                        if (function != null)
                        {
                            function.Offsets.Add(generator.programPointer + 1);
                        }
                        else
                        {
                            function = new StatementNode { Name = Parameters[0] };
                            function.Offsets.Add(generator.programPointer + 1);
                            generator.functions.Add(function);
                        }

                        byteCode = generator.GetCallCode(Parameters);
                    } break;
                case Command.NOP:
                    byteCode = generator.GetNopCode();
                    break;
                default:
                    throw new ProgramNodeBuilderExeption(string.Format("Unexpected token: {0}", parsedCommand));
            }

            Array.Copy(byteCode.Code, 0, generator.Body, generator.programPointer, byteCode.Code.Length);
            generator.programPointer += byteCode.Code.Length;

            Array.Copy(generator.FunctionDifenitions, 0, generator.Body, generator.programPointer, generator.FunctionDifenitions.Length);
        }
    }
}
