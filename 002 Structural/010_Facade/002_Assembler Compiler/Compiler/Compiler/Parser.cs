using System;
using System.Collections.Generic;
using System.Linq;

namespace CompilationSystem
{
    // Парсер проверяет правильность (допустимость) инструкций, анализируя лексемы из токенов.
    internal class Parser
    {
        Dictionary<string, int> variables = new Dictionary<string, int>();

        Scanner scanner;
        ProgramNodeBuilder builder;

        public void Parse(Scanner scanner, ProgramNodeBuilder builder, string sourceCode)
        {
            this.scanner = scanner;
            this.builder = builder;

            // Разбить программу на токены состоящие из лексем.
            List<Token> tokens = scanner.Scan(sourceCode);

            // Проверить каждый токен состоящий из лексем на ошибки.
            foreach (Token token in tokens)
            {
                ParseToken(token.Lexemes);
            }

            builder.Build(tokens);
        }

        private void ParseToken(List<string> lexemes)
        {
            Command parsedCommand;

            if (Enum.TryParse<Command>(lexemes[0].ToUpper(), out parsedCommand))
            {
                lexemes.RemoveAt(0);
                string[] parameters = string.Join(string.Empty, lexemes)
                                             .Replace(" ", string.Empty)
                                             .Split(Constants.parameterDelimiter, StringSplitOptions.RemoveEmptyEntries);


                VerifyParameters(parameters, parsedCommand);
                builder.AddStatementNode(parsedCommand.ToString(), parameters);
            }
            else // Анализ переменных.
            {

                int parsedVal;

                if (lexemes.Count() == 3 && lexemes[1].ToUpper() == "DD" && int.TryParse(lexemes[2], out parsedVal))
                {
                    if (!variables.ContainsKey(lexemes[0]))
                    {
                        int value;

                        if (int.TryParse(lexemes[2], out value))
                        {
                            variables.Add(lexemes[0], value);
                            builder.AddVariableNode(lexemes[0], value);
                        }
                        else
                        {
                            throw new ParserException("Не возможно привести значение к целочисленному типу.");
                        }
                    }
                    else
                    {
                        throw new ParserException(string.Format("Переменная с именем {0} уже существует", lexemes[0]));
                    }
                }
                else
                {
                    throw new ParserException("Неправильный токен.");
                }
            }
        }

        private void VerifyParameters(string[] parameters, Command command)
        {
            switch (command)
            {
                case Command.MOV:
                case Command.ADD:
                case Command.SUB:
                    {
                        if (parameters.Count() != 2)
                            throw new ParserException(string.Format("Инструкция {0} должна иметь два параметра", command));

                        foreach (string parameter in parameters)
                        {
                            int val;

                            if (!variables.ContainsKey(parameter) && !int.TryParse(parameter, out val) && parameter.ToUpper() != Constants.eax)
                                throw new ParserException(string.Format("Параметр {0} должен быть инициализированной переменной, целочисленным значением или допустимым регистром процессора.", parameters[1]));
                        }

                    } break;
                case Command.XOR:
                    {
                        if (parameters.Count() != 2)
                            throw new ParserException("Недопустимое количество параметров у инструкции XOR");

                        if (parameters[0].ToUpper() != Constants.eax || parameters[1].ToUpper() != Constants.eax)
                            throw new ParserException("Недопустимый формат инструкции XOR");

                    } break;
                case Command.CALL:
                    {
                        if (parameters.Count() != 1)
                            throw new ParserException("Недопустимое количество параметров у инструкции CALL");

                        string functionName = parameters[0].ToLower();

                        if (functionName != "HexMessage".ToLower() && functionName != "ExitProcess".ToLower())
                            throw new ParserException(string.Format("Имя функции {0} не существует в данном контексте.", parameters[0]));

                    } break;
                case Command.NOP:
                    {
                        if (parameters.Count() != 0)
                            throw new ParserException("Команда NOP не должна иметь параметров.");
                    } break;
            }
        }

        private void VerificationVariableName(string name)
        {
            if (name.Contains('.'))
                throw new ScannerExeption("Переменная содержит недопустимые символы.");
        }
    }
}
