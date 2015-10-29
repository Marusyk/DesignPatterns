using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Document_Converter
{
    // Product
    class TextWidget : Control
    {
        const float lineHeight = 25;
        List<string> lines = new List<string>();

        public TextWidget()
        {
            Paint += TextWidget_Paint;
        }

        /// <summary>
        /// Метод определения и задания стиля отображения текстового виджета.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TextWidget_Paint(object sender, PaintEventArgs e)
        {
            int lineCount = 0;
            Graphics g = e.Graphics;
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 20, 20), Color.Black, Color.Red, 45);

            foreach (string line in lines)
            {
                g.DrawString(line, new Font(FontFamily.GenericSansSerif, 20), brush, 10, lineCount * lineHeight);
                lineCount++;
            }
        }

        /// <summary>
        /// Метод добавления строки в виджет.
        /// </summary>
        /// <param name="str"></param>
        public void WriteLine(string str)
        {
            lines.Add(str);
        }
    }
}
