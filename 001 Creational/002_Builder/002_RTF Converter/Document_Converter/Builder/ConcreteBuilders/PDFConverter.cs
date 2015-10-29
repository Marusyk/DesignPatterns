using System;
using System.Drawing;

namespace Document_Converter
{
    // ConcreteBuilder
    class PDFConverter : TextConverter
    {
        PDFText text = new PDFText();

        /// <summary>
        /// Метод возвращающий текст конвертированый в PDF-формат.
        /// </summary>
        /// <returns></returns> 
        public PDFText GetPDFText()
        {
            return text;
        }

        /// <summary>
        /// Метод конвертации символа.
        /// </summary>
        /// <param name="character"></param>
        public override void ConvertCharacter(char character)
        {
            text.AddChar(character);
        }

        /// <summary>
        /// Метод конвертации абзаца текста.
        /// </summary>
        /// <param name="character"></param>       
        public override void ConvertParagraph()
        {
            text.NewLine();
        }

        /// <summary>
        /// Метод конвертации жирного шрифта.
        /// </summary>
        /// <param name="isBold"></param>
        public override void ConvertBold(bool isBold)
        {
            text.FontToBold(isBold);
        }

        /// <summary>
        /// Метод конвертации курсивного шрифта.
        /// </summary>
        /// <param name="isItalic"></param>
        public override void ConvertItalic(bool isItalic)
        {
            text.FontToItalic(isItalic);
        }
    }
}
