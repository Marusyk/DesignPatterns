using System.Text;
using System.IO;

namespace Document_Converter
{
    // Product
    class ASCIIText
    {
        private StringBuilder text = new StringBuilder();

        /// <summary>
        /// Метод добавления конвертированого символа.
        /// </summary>
        /// <returns></returns>
        public void addChar(char character)
        {
            text.Append(character);
        }

        /// <summary>
        /// Метод добавления конвертированой строки.
        /// </summary>
        /// <returns></returns>
        public void NewLine()
        {
            text.AppendLine();
        }

        /// <summary>
        /// Метод записи конвертированого файла в текстовый файл.
        /// </summary>
        /// <returns></returns>
        public void WriteToFile(string fileName)
        {
            File.WriteAllText(fileName, text.ToString(), Encoding.ASCII);
        }
    }
}
