using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler
{
    internal class Scanner
    {
        protected Scanner() { }

        private static Scanner _instancel;
        public static Scanner Instance
        {
            get
            {
                if (_instancel == null)
                {
                    _instancel = new Scanner();
                }

                return _instancel;
            }

            private set { }
        }

        public string Scan(string code, out string[] outputCommands)
        {
            string[] commands = code.Trim().Split(Constants.ProgramDelimiter, StringSplitOptions.RemoveEmptyEntries);

            foreach (string command in commands)
            {
                Command parsedComand;

                List<string> lexemes = command.Split(Constants.LexemesDelimiter, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!Enum.TryParse<Command>(lexemes[0].ToUpper(), out parsedComand))
                {
                    if (!IsCorrectVariableName(lexemes[0]))
                    {
                        outputCommands = null;
                        return string.Format("Unexpected command: {0}", command);
                    }
                }
            }

            outputCommands = commands;
            return null;
        }

        private bool IsCorrectVariableName(string name)
        {
            return true;
        }
    }
}
