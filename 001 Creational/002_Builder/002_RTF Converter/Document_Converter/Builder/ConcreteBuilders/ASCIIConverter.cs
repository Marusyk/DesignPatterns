using System;
using System.Drawing;

namespace Document_Converter
{
    // ConcreteBuilder
    class ASCIIConverter : TextConverter
    {
        ASCIIText text = new ASCIIText();

        /// <summary>
        /// Метод возвращающий текст конвертированый в ASCII-формат.
        /// </summary>
        /// <returns></returns>
        public ASCIIText GetASCIIText()
        {
            return text;
        }

        /// <summary>
        /// Метод конвертации символа.
        /// </summary>
        /// <param name="character"></param>
        public override void ConvertCharacter(char character)
        {
            text.addChar(character);
        }

        /// <summary>
        /// Метод конвертации абзаца текста.
        /// </summary>
        public override void ConvertParagraph()
        {
            text.NewLine();
        }

        /// <summary>
        /// Неиспользуемая функция ASCII конвертером.
        /// </summary>
        /// <param name="isBold"></param>        
        public override void ConvertBold(bool isBold)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Неиспользуемая функция ASCII конвертером.
        /// </summary>
        /// <param name="isBold"></param>
        public override void ConvertItalic(bool isItalic)
        {
            throw new InvalidOperationException();
        }
    }
}
