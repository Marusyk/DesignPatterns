using System;
using System.Text;

namespace Document_Converter
{
    // ConcreteBuilder
    class TextWidgetConverter : TextConverter
    {
        TextWidget text = new TextWidget();
        StringBuilder textLine = new StringBuilder();

        /// <summary>
        /// Метод возвращающий текст конвертированый в TextWidget.
        /// </summary>
        /// <returns></returns>
        public TextWidget GetTextWidget()
        {
            return text;
        }

        /// <summary>
        /// Метод конвертации символа.
        /// </summary>
        /// <param name="character"></param>
        public override void ConvertCharacter(char character)
        {
            textLine.Append(character.ToString());
        }

        /// <summary>
        /// Метод конвертации абзаца текста.
        /// </summary>
        public override void ConvertParagraph()
        {
            text.WriteLine(textLine.ToString());
            textLine.Clear();
        }

        /// <summary>
        /// Неиспользуемая функция Widget конвертером.
        /// </summary>
        /// <param name="isBold"></param>
        public override void ConvertBold(bool isBold)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Неиспользуемая функция Widget конвертером.
        /// </summary>
        /// <param name="isBold"></param>
        public override void ConvertItalic(bool isItalic)
        {
            throw new InvalidOperationException();
        }
    }
}
