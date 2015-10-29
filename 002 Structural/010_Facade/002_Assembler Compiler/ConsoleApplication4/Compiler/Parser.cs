using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler
{
    internal class Parser
    {
        Dictionary<string, int> variables = new Dictionary<string, int>();

        protected Parser() { }

        private static Parser _instancel;
        public static Parser Instance
        {
            get
            {
                if (_instancel == null)
                {
                    _instancel = new Parser();
                }

                return _instancel;
            }

            private set { }
        }

        public string Parse(string[] commands)
        {
            foreach (var command in commands)
            {
                List<string> lexemes = command.Split(Constants.LexemesDelimiter, StringSplitOptions.RemoveEmptyEntries).ToList();

                Command parsedCommand;
                string error = null;

                if (Enum.TryParse<Command>(lexemes[0].ToUpper(), out parsedCommand))
                {
                    lexemes.RemoveAt(0);

                    string[] parameters = string.Join(string.Empty, lexemes)
                                                .Replace(" ", string.Empty)
                                                .Split(Constants.ParameterDelimiter, StringSplitOptions.RemoveEmptyEntries);

                    error = CheckCommandParameters(parameters, parsedCommand);
                }
                else
                {
                    int parsedVal;

                    if (lexemes.Count() == 3 &&
                        lexemes[1].ToUpper() == "DB" &&
                        int.TryParse(lexemes[2], out parsedVal))
                    {
                        if (!variables.ContainsKey(lexemes[0]))
                        {
                            int value;

                            if (int.TryParse(lexemes[2], out value))
                            {
                                variables.Add(lexemes[0], value);
                            }
                            else
                            {
                                error = "Can not parse value into integer";
                            }
                        }
                        else
                        {
                            error = "The variable with this name already exists";
                        }
                    }
                    else
                    {
                        error = "Wrong command";
                    }
                }

                if (!string.IsNullOrEmpty(error))
                {
                    return string.Format("{0};\r\nCommand: {1}", error, command);
                }
            }

            return null;
        }

        private string CheckCommandParameters(string[] parameters, Command comand)
        {
            switch (comand)
            {
                case Command.MOV:
                case Command.ADD:
                case Command.SUB:
                    {
                        if (parameters.Count() != 2)
                        {
                            return "Unexpected parameters count";
                        }

                        foreach (string parameter in parameters)
                        {
                            int val;
                            if (!variables.ContainsKey(parameter) && !int.TryParse(parameter, out val) && parameter.ToUpper() != Constants.EAX)
                            {
                                return string.Format("Parameter {0} should be an initialized variable, integer value or valid register", parameters[1]);
                            }
                        }

                    } break;
                case Command.XOR:
                    {
                        if (parameters.Count() != 2)
                        {
                            return "Unexpected parameters count";
                        }

                        if (parameters[0].ToUpper() != Constants.EAX || parameters[1].ToUpper() != Constants.EAX)
                        {
                            return "Command does not supported";
                        }

                    } break;
                case Command.CALL:
                    {
                        if (parameters.Count() != 1)
                        {
                            return "Unexpected parameters count";
                        }

                        string functionName = parameters[0].ToLower();
                        if (functionName != "HexMessage".ToLower() && functionName != "ExitProcess".ToLower())
                        {
                            return "Unexpected function name";
                        }
                    } break;
                case Command.NOP:
                    {
                        if (parameters.Count() != 0)
                        {
                            return "Unexpected parameters count";
                        }
                    } break;
            }

            return null;
        }
    }
}
