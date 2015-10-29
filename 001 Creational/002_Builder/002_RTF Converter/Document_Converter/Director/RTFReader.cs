using System;
using System.Text;
using System.IO;

namespace Document_Converter
{
    // Спецификация описывающая формат RTF:
    // http://msdn.microsoft.com/en-us/library/office/aa140277(v=office.10).aspx

    // Director
    class RTFReader
    {
        private string textRTF;
        private int curentSymbol;
        TextConverter converter;

        public RTFReader(TextConverter converter)
        {
            this.converter = converter;
        }

        /// <summary>
        /// Метод считывания текста заключенного в лексему.
        /// </summary>
        /// <param name="textRTF"></param>
        public void ParserRTF(string textRTF)
        {
            this.textRTF = textRTF;
            curentSymbol = 1;
            ParseRTF();
        }

        /// <summary>
        /// Метод который парсит строки находя лексемы.
        /// </summary>
        private void ParseRTF()
        {
            while (curentSymbol < textRTF.Length)
            {
                if (textRTF[curentSymbol] == '\r' || textRTF[curentSymbol] == '\n')
                {
                    curentSymbol++;
                    continue;
                }

                switch (textRTF[curentSymbol])
                {
                    case '{':
                        {
                            curentSymbol++;

                            if (textRTF[curentSymbol] == '\\')
                            {
                                ReadLexemeGroup();
                            }
                            else
                            {
                                //Вызов метода считывания текста.
                                ParseRTF();
                            }
                            break;
                        }
                    case '}':
                        {
                            curentSymbol++;
                            return;
                        }
                    case '\\':
                        {
                            if (textRTF[curentSymbol + 1] == '\'')
                            {
                                //Определение окончания лексемы.
                                ReadEscapedChar();
                                break;
                            }

                            //Вызов метода считывания лексемы.
                            ReadLexeme();

                            if (textRTF[curentSymbol] != '{' && textRTF[curentSymbol] != '\\')
                            {
                                curentSymbol++;
                            }
                            break;
                        }
                    default:
                        {
                            converter.ConvertCharacter(textRTF[curentSymbol]);
                            curentSymbol++;
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Метод считывания лексемы.
        /// </summary>
        void ReadLexeme()
        {
            curentSymbol++;
            string lexeme = "";

            while (curentSymbol < textRTF.Length && !IsLexemeStopSimbol(textRTF[curentSymbol]))
            {
                if (textRTF[curentSymbol] == '\r' || textRTF[curentSymbol] == '\n')
                {
                    curentSymbol++;
                    continue;
                }

                lexeme += textRTF[curentSymbol];
                curentSymbol++;
            }

            Action(lexeme);
        }

        /// <summary>
        /// Метод считывания символа окончания лексемы.
        /// </summary>
        void ReadEscapedChar()
        {
            curentSymbol += 2;
            int i = Convert.ToInt32(textRTF[curentSymbol].ToString() + textRTF[curentSymbol + 1], 16);
            byte[] intBytes = BitConverter.GetBytes(i);
            StreamReader r = new StreamReader(new MemoryStream(intBytes), Encoding.GetEncoding("windows-1251"));
            Encoding.GetEncoding("windows-1251");
            string str = r.ReadToEnd();
            converter.ConvertCharacter(str[0]);
            curentSymbol += 2;
        }

        /// <summary>
        /// Метод считывания группы лексем.
        /// </summary>
        /// <returns></returns>
        string ReadLexemeGroup()
        {
            string group = "{";

            while (textRTF[curentSymbol] != '}')
            {
                if (textRTF[curentSymbol] == '{')
                {
                    curentSymbol++;
                    group += ReadLexemeGroup();
                    continue;
                }

                group += textRTF[curentSymbol];
                curentSymbol++;
            }

            group += textRTF[curentSymbol];
            curentSymbol++;
            return group;
        }

        /// <summary>
        /// Принимает лексемы RTF. Для каждой лексемы вызывается сответствующая команда в converter.
        /// </summary>
        /// <param name="lexeme"></param>
        private void Action(string lexeme)
        {
            switch (lexeme)
            {
                case "b":
                    {
                        if (!(converter is ASCIIConverter || converter is TextWidgetConverter))
                            converter.ConvertBold(true);
                        break;
                    }
                case "b0":
                    {
                        if (!(converter is ASCIIConverter || converter is TextWidgetConverter))
                            converter.ConvertBold(false);
                        break;
                    }
                case "i":
                    {
                        if (!(converter is ASCIIConverter || converter is TextWidgetConverter))
                            converter.ConvertItalic(true);
                        break;
                    }
                case "i0":
                    {
                        if (!(converter is ASCIIConverter || converter is TextWidgetConverter))
                            converter.ConvertItalic(false);
                        break;
                    }
                case "par":
                    converter.ConvertParagraph();
                    break;
            }
        }

        /// <summary>
        /// Проверяет является ли символ признаком конца лексемы.
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        bool IsLexemeStopSimbol(char character)
        {
            return character == ' ' || character == '\\' || character == '}' || character == '{';
        }
    }
}
