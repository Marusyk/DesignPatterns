using System;
using System.Collections.Generic;

namespace CompilationSystem
{
    // Сканер разбивает программный код на отдельные инструкции представленные токенами (Token).
    public class Scanner
    {
        List<Token> tokens = new List<Token>();

        public List<Token> Scan(string sourceCode)
        {
            string[] commands = sourceCode.Trim().Split(Constants.programDelimiter, StringSplitOptions.RemoveEmptyEntries);

            foreach (string command in commands)
            {
                string[] lexemes = command.Split(Constants.lexemesDelimiter, StringSplitOptions.RemoveEmptyEntries);
                this.tokens.Add(new Token(lexemes));
            }

            return tokens;
        }
    }
}