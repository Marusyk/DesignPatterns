using System;
using System.IO;

// В даном примере была использована библиотека sharpPDF 
// для генерации документов в PDF формате:
// http://sharppdf.sourceforge.net/

using sharpPDF;
using sharpPDF.Fonts;
using sharpPDF.Elements;
using sharpPDF.Enumerators;

namespace Document_Converter
{
    // Product
    class PDFText
    {
        pdfDocument pdfData = new pdfDocument("testPDF", "CyberBionic");
        pdfAbstractFont currentPDFfont;
        textElement currentCharElem;
        int lastElemPostionY = 470;

        /// <summary>
        /// Конструктор конкретного продукта (документа) в формате PDF.
        /// </summary>
        public PDFText()
        {
            // Добавление новой страницы в PDF документ с разрешением 500х500px.
            pdfData.addPage(500, 500);
            //Устанавка шрифта документа по умолчанию.
            currentPDFfont = pdfData.getFontReference(pdfFont.getFontName(predefinedFont.csHelvetica));
            //Создание текстового елемента (в подключеной библиотеке sharpPDF это контейнер для символьных данных, аналогично блоку текста/f,pfwf).
            currentCharElem = new textElement(String.Empty, 14, currentPDFfont, 30, lastElemPostionY);
            //Устанавка Y-координаты последнего символа в документе.
            lastElemPostionY = currentCharElem.coordY;
        }

        /// <summary>
        /// Метод добавления символа.
        /// </summary>
        /// <param name="character"></param>
        public void AddChar(char character)
        {
            currentCharElem.content += character;
        }

        /// <summary>
        /// Метод добавления новой строки в файл.
        /// </summary>
        public void NewLine()
        {
            //Добавление PDF-елемента на текущую страницу документа.
            pdfData.persistentPage.addElement(currentCharElem);
            //Создание нового елемента (абзаца).
            currentCharElem = new textElement(String.Empty, 14, currentPDFfont, 30, lastElemPostionY - 20);
            //Задание Y-координаты для новой строки на странице (отсчет координат с левого нижнего угла страницы).
            lastElemPostionY = lastElemPostionY - 20;
        }

        /// <summary>
        /// Метод изменяющий тип шрифта блока текста на курсивный.
        /// </summary>
        /// <param name="isItalic"></param>
        public void FontToItalic(bool isItalic)
        {
            if (isItalic)
                currentCharElem.fontType = pdfData.getFontReference(pdfFont.getFontName(predefinedFont.csHelveticaOblique));
            else
                currentCharElem.fontType = pdfData.getFontReference(pdfFont.getFontName(predefinedFont.csHelvetica));
        }

        /// <summary>
        /// Метод изменяющий тип шрифта блока текста на жирный.
        /// </summary>
        /// <param name="isBold"></param>
        public void FontToBold(bool isBold)
        {
            if (isBold)
                currentCharElem.fontType = pdfData.getFontReference(pdfFont.getFontName(predefinedFont.csHelveticaBold));
            else
                currentCharElem.fontType = pdfData.getFontReference(pdfFont.getFontName(predefinedFont.csHelvetica));
        }

        /// <summary>
        /// Метод для записи конвертированого текста в PDF документ.
        /// </summary>
        /// <param name="p"></param>
        public void WriteToFile(string p)
        {
            if (File.Exists(p)) File.Delete(p);
            pdfData.createPDF(p);
        }
    }
}
