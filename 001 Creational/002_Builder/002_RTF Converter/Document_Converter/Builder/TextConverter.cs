using System.Drawing;

namespace Document_Converter
{
    // Builder
    abstract class TextConverter
    {
        /// <summary>
        /// Абстрактный метод конвертации символа.
        /// </summary>
        /// <returns></returns>
        public abstract void ConvertCharacter(char character);

        /// <summary>
        /// Абстрактный метод конвертации жирного текста.
        /// </summary>
        /// <returns></returns>
        public abstract void ConvertBold(bool isBold);

        /// <summary>
        /// Абстрактный метод конвертации курсивного текста.
        /// </summary>
        /// <returns></returns>
        public abstract void ConvertItalic(bool isItalic);

        /// <summary>
        /// Абстрактный метод конвертации абзаца.
        /// </summary>
        /// <returns></returns>
        public abstract void ConvertParagraph();
    }
}
